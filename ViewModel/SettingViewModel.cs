using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using IWshRuntimeLibrary;
using System.Diagnostics;
using NetworkTool.Common;
using NetworkTool.Model;
using System.Windows.Controls;

namespace NetworkTool.ViewModel
{
    class SettingViewModel
    {
        /// <summary>
        /// 开机启动程序命令
        /// </summary>
        public CommandBase BootWithSystemCommand { get; set; }
        /// <summary>
        /// 自动连接校园网命令
        /// </summary>
        public CommandBase AutoLinkCommand { get; set; }
        /// <summary>
        /// 创建快捷方式命令
        /// </summary>
        public CommandBase CreateShotcutCommand { get; set; }
        /// <summary>
        /// 开启Window11风格
        /// </summary>
        public CommandBase SetCornerCommand { get; set; }

        public SettingModel SettingModel { get; set; }


        /// <summary>
        /// 快捷方式名称-任意自定义
        /// </summary>
        private const string QuickName = "200-OK";

        private const string ConsleQuickName = "AutoLinkConsole";

        /// <summary>
        /// 自动获取系统自动启动目录
        /// </summary>
        private string systemStartPath { get { return Environment.GetFolderPath(Environment.SpecialFolder.Startup); } }

        /// <summary>
        /// 自动获取程序完整路径
        /// </summary>
        private string appAllPath { get { return Process.GetCurrentProcess().MainModule.FileName; } }

        /// <summary>
        /// 自动获取Console程序完整路径
        /// </summary>
        private string consolePath { get { return AppDomain.CurrentDomain.BaseDirectory + $"Console\\{ConsleQuickName}.exe"; } }

        /// <summary>
        /// 自动获取图标完整路径
        /// </summary>
        private string iconPath { get { return AppDomain.CurrentDomain.BaseDirectory + "Assets\\rabbit.ico"; } }

        /// <summary>
        /// 自动获取桌面目录
        /// </summary>
        private string desktopPath { get { return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); } }

        public SettingViewModel()
        {

            this.SettingModel = new SettingModel();
            SettingModel.CornerRadius = Properties.Settings.Default.CornerRadius;
            SettingModel.Corner = Properties.Settings.Default.Corner;
            SettingModel.Boot = Properties.Settings.Default.Boot;
            SettingModel.Link = Properties.Settings.Default.Link;
            SettingModel.Shortcut = Properties.Settings.Default.Shortcut;

            //开机启动程序
            this.BootWithSystemCommand = new CommandBase();
            this.BootWithSystemCommand.DoExecute = new Action<object>((o) =>
            {
                bool select = (bool)(o as CheckBox).IsChecked;

                SetMeAutoStart(select);

                Properties.Settings.Default.Boot = select;
                Properties.Settings.Default.Save();
            });
            this.BootWithSystemCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            //开机自动连接校园网
            this.AutoLinkCommand = new CommandBase();
            this.AutoLinkCommand.DoExecute = new Action<object>((o) =>
            {
                bool select = (bool)(o as CheckBox).IsChecked;
                SetAutoLinkWhenStart(select);
                Properties.Settings.Default.Link = select;
                Properties.Settings.Default.Save();
            });
            this.AutoLinkCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            //创建桌面快捷方式
            this.CreateShotcutCommand = new CommandBase();
            this.CreateShotcutCommand.DoExecute = new Action<object>((o) =>
            {
                bool select = (bool)(o as CheckBox).IsChecked;
                if (select)
                {
                    CreateDesktopQuick(desktopPath, QuickName, appAllPath);
                }
                Properties.Settings.Default.Shortcut = select;
                Properties.Settings.Default.Save();
            });
            this.CreateShotcutCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            //Windows11风格
            this.SetCornerCommand = new CommandBase();
            this.SetCornerCommand.DoExecute = new Action<object>((o) =>
            {
                bool select=(bool)(o as CheckBox).IsChecked;
                if (select)
                {
                    Properties.Settings.Default.CornerRadius = Function.win11Radius;
                }
                else
                {
                    Properties.Settings.Default.CornerRadius = Function.defaultRadius;
                }
                Properties.Settings.Default.Corner = select;
                Properties.Settings.Default.Save();
            });
            this.SetCornerCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        /// <summary>
        /// 设置开机自动启动-只需要调用改方法就可以了参数里面的bool变量是控制开机启动的开关的，默认为开启自启启动
        /// </summary>
        /// <param name="onOff">自启开关</param>
        public void SetMeAutoStart(bool onOff = true)
        {
            if (onOff)//开机启动
            {
                //获取启动路径应用程序快捷方式的路径集合
                List<string> shortcutPaths = GetQuickFromFolder(systemStartPath, appAllPath);
                //存在2个以快捷方式则保留一个快捷方式-避免重复多于
                if (shortcutPaths.Count >= 2)
                {
                    for (int i = 1; i < shortcutPaths.Count; i++)
                    {
                        DeleteFile(shortcutPaths[i]);
                    }
                }
                else if (shortcutPaths.Count < 1)//不存在则创建快捷方式
                {
                    CreateShortcut(systemStartPath, QuickName, appAllPath, "200-OK");
                }
            }
            else//开机不启动
            {
                //获取启动路径应用程序快捷方式的路径集合
                List<string> shortcutPaths = GetQuickFromFolder(systemStartPath, appAllPath);
                //存在快捷方式则遍历全部删除
                if (shortcutPaths.Count > 0)
                {
                    for (int i = 0; i < shortcutPaths.Count; i++)
                    {
                        DeleteFile(shortcutPaths[i]);
                    }
                }
            }
            //创建桌面快捷方式-如果需要可以取消注释
            //CreateDesktopQuick(desktopPath, QuickName, appAllPath);
        }

        /// <summary>
        /// 开机自动连接校园网
        /// </summary>
        /// <param name="onOff"></param>
        public void SetAutoLinkWhenStart(bool onOff)
        {
            if (onOff)//开机启动
            {
                //获取启动路径应用程序快捷方式的路径集合
                List<string> shortcutPaths = GetQuickFromFolder(systemStartPath, consolePath);
                //存在2个以快捷方式则保留一个快捷方式-避免重复多于
                if (shortcutPaths.Count >= 2)
                {
                    for (int i = 1; i < shortcutPaths.Count; i++)
                    {
                        DeleteFile(shortcutPaths[i]);
                    }
                }
                else if (shortcutPaths.Count < 1)//不存在则创建快捷方式
                {
                    CreateShortcut(systemStartPath, ConsleQuickName, consolePath, "开机自动连接校园网");
                }
            }
            else//开机不启动
            {
                //获取启动路径应用程序快捷方式的路径集合
                List<string> shortcutPaths = GetQuickFromFolder(systemStartPath, consolePath);
                //存在快捷方式则遍历全部删除
                if (shortcutPaths.Count > 0)
                {
                    for (int i = 0; i < shortcutPaths.Count; i++)
                    {
                        DeleteFile(shortcutPaths[i]);
                    }
                }
            }
        }

        /// <summary>
        ///  向目标路径创建指定文件的快捷方式
        /// </summary>
        /// <param name="directory">目标目录</param>
        /// <param name="shortcutName">快捷方式名字</param>
        /// <param name="targetPath">文件完全路径</param>
        /// <param name="description">描述</param>
        /// <param name="iconLocation">图标地址</param>
        /// <returns>成功或失败</returns>
        private bool CreateShortcut(string directory, string shortcutName, string targetPath, string description = null, string iconLocation = null)
        {
            try
            {
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);                         //目录不存在则创建
                //添加引用 Com 中搜索 Windows Script Host Object Model
                string shortcutPath = Path.Combine(directory, string.Format("{0}.lnk", shortcutName));          //合成路径
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);    //创建快捷方式对象
                shortcut.TargetPath = targetPath;                                                               //指定目标路径
                shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath);                                  //设置起始位置
                shortcut.WindowStyle = 1;                                                                       //设置运行方式，默认为常规窗口
                shortcut.Description = description;                                                             //设置备注
                shortcut.IconLocation = string.IsNullOrWhiteSpace(iconLocation) ? targetPath : iconLocation;    //设置图标路径
                shortcut.Save();                                                                                //保存快捷方式
                return true;
            }
            catch (Exception ex)
            {
                string temp = ex.Message;
                temp = "";
            }
            return false;
        }

        /// <summary>
        /// 获取指定文件夹下指定应用程序的快捷方式路径集合
        /// </summary>
        /// <param name="directory">文件夹</param>
        /// <param name="targetPath">目标应用程序路径</param>
        /// <returns>目标应用程序的快捷方式</returns>
        private List<string> GetQuickFromFolder(string directory, string targetPath)
        {
            List<string> tempStrs = new List<string>();
            tempStrs.Clear();
            string tempStr = null;
            string[] files = Directory.GetFiles(directory, "*.lnk");
            if (files == null || files.Length < 1)
            {
                return tempStrs;
            }
            for (int i = 0; i < files.Length; i++)
            {
                //files[i] = string.Format("{0}\\{1}", directory, files[i]);
                tempStr = GetAppPathFromQuick(files[i]);
                if (tempStr == targetPath)
                {
                    tempStrs.Add(files[i]);
                }
            }
            return tempStrs;
        }

        /// <summary>
        /// 获取快捷方式的目标文件路径-用于判断是否已经开启了自动启动
        /// </summary>
        /// <param name="shortcutPath"></param>
        /// <returns></returns>
        private string GetAppPathFromQuick(string shortcutPath)
        {
            //快捷方式文件的路径 = @"d:\Test.lnk";
            if (System.IO.File.Exists(shortcutPath))
            {
                WshShell shell = new WshShell();
                IWshShortcut shortct = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                //快捷方式文件指向的路径.Text = 当前快捷方式文件IWshShortcut类.TargetPath;
                //快捷方式文件指向的目标目录.Text = 当前快捷方式文件IWshShortcut类.WorkingDirectory;
                return shortct.TargetPath;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 根据路径删除文件-用于取消自启时从计算机自启目录删除程序的快捷方式
        /// </summary>
        /// <param name="path">路径</param>
        private void DeleteFile(string path)
        {
            FileAttributes attr = System.IO.File.GetAttributes(path);
            if (attr == FileAttributes.Directory)
            {
                Directory.Delete(path, true);
            }
            else
            {
                System.IO.File.Delete(path);
            }
        }

        /// <summary>
        /// 在桌面上创建快捷方式-如果需要可以调用
        /// </summary>
        /// <param name="desktopPath">桌面地址</param>
        /// <param name="appPath">应用路径</param>
        public void CreateDesktopQuick(string desktopPath = "", string quickName = "", string appPath = "")
        {
            List<string> shortcutPaths = GetQuickFromFolder(desktopPath, appPath);
            //如果没有则创建
            if (shortcutPaths.Count < 1)
            {
                CreateShortcut(desktopPath, quickName, appPath, description:"200-OK",iconLocation:iconPath);
            }
        }
    }
}
