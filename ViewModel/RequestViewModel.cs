using NetworkTool.Common;
using NetworkTool.Model;
using NetworkTool.View.Pages;
using Panuon.UI.Silver;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NetworkTool.ViewModel
{
    class RequestViewModel
    {
        public RequestModel RequestModel { get; set; }

        //保存命令
        public CommandBase SaveRequestCommand { get; set; }


        public RequestViewModel()
        {

            this.RequestModel = new RequestModel();
            this.RequestModel.CornerRadius = Properties.Settings.Default.CornerRadius;
            this.RequestModel.URL = Properties.Settings.Default.RequestURL;
            this.RequestModel.Header = Properties.Settings.Default.RequestHeader;
            this.RequestModel.Data = Properties.Settings.Default.RequestData;


            //保存参数
            this.SaveRequestCommand = new CommandBase();
            this.SaveRequestCommand.DoExecute = new Action<object>(async (o) =>
            {
                SaveConfiguration(this.RequestModel);
                SaveSharedConfiguration(this.RequestModel);
                var result = MessageBoxX.Show("Enjoy it!", "保存成功", Application.Current.MainWindow, MessageBoxButton.OK, new Panuon.UI.Silver.Core.MessageBoxXConfigurations()
                {
                    MessageBoxStyle = MessageBoxStyle.Modern,
                    MessageBoxIcon = MessageBoxIcon.Success,
                    ButtonBrush = "#FF4C4C".ToColor().ToBrush(),
                });
                //委托
                new WelcomePage();
            });
            this.SaveRequestCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        public void SaveSharedConfiguration(RequestModel request)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["RequestURL"].Value = request.URL;
            config.AppSettings.Settings["RequestHeader"].Value = request.Header;
            config.AppSettings.Settings["RequestData"].Value = request.Data;
            //一定要记得保存，写不带参数的config.Save()也可以
            config.Save(ConfigurationSaveMode.Modified);
            //刷新，否则程序读取的还是之前的值（可能已装入内存）
            ConfigurationManager.RefreshSection("appSettings");
        }

        public void SaveConfiguration(RequestModel request)
        {
            Properties.Settings.Default.RequestURL = request.URL;
            Properties.Settings.Default.RequestHeader = request.Header;
            Properties.Settings.Default.RequestData = request.Data;
            Properties.Settings.Default.Save();
        }


    }
}

//PingReply reply = await Network.PingHostAsync("baidu.com");
//if (reply.Status==IPStatus.Success)
//{
//    Trace.WriteLine("已经连通");
//    Trace.WriteLine(reply);
//}
//IRestResponse response = await Function.SendRequestAsync();
//if (!response.IsSuccessful)
//{
//    var result = MessageBoxX.Show("未连接到校园WIFI", "连接失败", Application.Current.MainWindow, MessageBoxButton.OK, new Panuon.UI.Silver.Core.MessageBoxXConfigurations()
//    {
//        MessageBoxIcon = MessageBoxIcon.Error,
//        ButtonBrush = "#FF4C4C".ToColor().ToBrush(),
//    });
//    return;
//}
//string ResponseUri = response.ResponseUri.AbsoluteUri;
////Trace.WriteLine(Regex.Match(ResponseUri, @"(?i)error").Success);// response.ContentLength:
//bool error = Regex.Match(ResponseUri, @"(?i)error").Success;
//if (error)
//{
//    var result = MessageBoxX.Show("账号或密码错误", "连接失败", Application.Current.MainWindow, MessageBoxButton.OK, new Panuon.UI.Silver.Core.MessageBoxXConfigurations()
//    {
//        MessageBoxIcon = MessageBoxIcon.Warning,
//        ButtonBrush = "#FF4C4C".ToColor().ToBrush(),
//    });
//}

//if (response.IsSuccessful && !error)
//{
//    var result = MessageBoxX.Show("Enjoy it!", "连接成功", Application.Current.MainWindow, MessageBoxButton.OK, new Panuon.UI.Silver.Core.MessageBoxXConfigurations()
//    {
//        MessageBoxIcon = MessageBoxIcon.Success,
//        ButtonBrush = "#FF4C4C".ToColor().ToBrush(),
//    });

//}

//if (!response.issuccessful)
//{
//    var result = messageboxx.show("请检查网络并重试", "连接失败", application.current.mainwindow, messageboxbutton.ok, new panuon.ui.silver.core.messageboxxconfigurations()
//    {
//        messageboxicon = messageboxicon.error,
//        buttonbrush = "#ff4c4c".tocolor().tobrush(),
//    });
//}