using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using NetworkTool.Common;
using NetworkTool.Model;
using RestSharp;

namespace NetworkTool.ViewModel
{
    public class MainViewModel
    {

        public MainModel MainModel { get; set; }

        public CommandBase CloseWindowCommand { get; set; }

        public CommandBase SendRequestCommand { get; set; }

        DispatcherTimer Timer = new DispatcherTimer();


        public MainViewModel()
        {

            this.MainModel = new MainModel();
            this.MainModel.CornerRadius = Properties.Settings.Default.CornerRadius;
            this.MainModel.StatusColor = Network.checkingColor;
            this.MainModel.StatusDescription = Network.checkingDescription;
            
            //设置定时器
            this.Timer.Interval = new TimeSpan(0, 1, 0);
            this.Timer.Tick += new EventHandler(async (object sender, EventArgs e) => {
                if (Network.check != 1)
                {
                    this.Timer.Stop();
                    return;
                }
                else
                {
                    PingReply baiduReplay = await Network.PingHostAsync(Properties.Settings.Default.BaiduHost);
                    if (baiduReplay.Status != IPStatus.Success)
                    {
                        CheckStatus(this.MainModel,Timer);
                    }
                }
            });
            this.Timer.Start();

            CheckStatus(this.MainModel,this.Timer);

            //实时检测网络状态
            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler((object sender, EventArgs e) =>
            {
                CheckStatus(this.MainModel,this.Timer);
            });


            //GO 发送请求
            this.SendRequestCommand = new CommandBase();
            this.SendRequestCommand.DoExecute = new Action<object>(async (o) =>
              {
                  
                  CheckStatus(this.MainModel, this.Timer);

                  if (Network.check!=2)
                  {
                      return;
                  }
                  IRestResponse response = await Function.SendRequestAsync();
                  string ResponseUri = response.ResponseUri.AbsoluteUri;
                  bool error = Regex.Match(ResponseUri, @"(?i)error").Success;
                  if (error)
                  {
                      this.MainModel.StatusColor = Network.waitConnectedColor;
                      this.MainModel.StatusDescription = "账号或密码错误";
                  }
                  else
                  {
                      this.MainModel.StatusColor = Network.connectedColor;
                      this.MainModel.StatusDescription = Network.connectedDescription;
                      Network.check = 1;
                      Timer.Start();
                  }
              });
            this.SendRequestCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            //关闭窗体
            this.CloseWindowCommand = new CommandBase();
            this.CloseWindowCommand.DoExecute = new Action<object>((o) =>
              {
                  (o as Window).Close();
              });

            this.CloseWindowCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });


        }

        /// <summary>
        /// 监控网络变化
        /// </summary>
        /// <param name="model"></param>
        private void CheckStatus(MainModel model,DispatcherTimer timer)
        {
            model.StatusDescription = Network.checkingDescription;
            model.StatusColor = Network.checkingColor;
            Task.Run(async () =>
            {
                int check = await Network.CheckConnectedAsync();
                Network.check = check;
                switch (check)
                {
                    case 1:
                        model.StatusColor = Network.connectedColor;
                        model.StatusDescription = Network.connectedDescription;
                        timer.Start();
                        break;
                    case 2:
                        model.StatusColor = Network.waitConnectedColor;
                        model.StatusDescription = Network.waitConnectedDescription;
                        timer.Stop();
                        break;
                    case 3:
                        model.StatusColor = Network.unConnectedColor;
                        model.StatusDescription = Network.unConnectedDescription;
                        timer.Stop();
                        break;
                    case 4:
                        model.StatusColor = Network.checkingColor;
                        model.StatusDescription = Network.nullDescription;
                        timer.Stop();
                        break;
                    default:
                        break;
                }
            });
        }

    }
}

