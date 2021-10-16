using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace NetworkTool.Common
{
    public static class Network
    {
        //10.0.251.18

        //检查
        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(int Description, int ReservedValue);

        public const int Description = 0;

        //状态枚举
        enum status
        {
            Connected = 1,
            Wait = 2,
            UnConnected = 3,
            Null=4
        }

        //状态颜色
        public const string connectedColor = "#41b883"; //已连接
        public const string unConnectedColor = "#963F3F3F"; //未连接
        public const string waitConnectedColor = "#ffc700"; //待认证（等待认证）
        public const string checkingColor = "#5b7fff";

        //状态说明
        public const string connectedDescription = "校园网已连接";
        public const string unConnectedDescription = "校园网未连接";
        public const string waitConnectedDescription = "校园网待认证";
        public const string checkingDescription = "正在检查网络状态";
        public const string nullDescription = "请求参数或校园网认证IP地址不能为空";

        //check
        public static int check = 2;


        /// <summary>
        /// 用于检查网络是否可用,true表示连接成功,false表示连接失败
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> IsNetworkAvailabilityAsync()
        {
            try
            {

                return await Task.Run(() =>
                {
                    return InternetGetConnectedState(Description, 0);

                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool IsNetworkAvailability()
        {
            return InternetGetConnectedState(Description, 0);
        }


        //Ping 测试连通性
        public static async Task<PingReply> PingHostAsync(string host)
        {
            
            try
            {
                return await Task.Run(() =>
                {
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(host);
                    return reply;
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        //检查网络状态
        public static async Task<int> CheckConnectedAsync()
        {
            string CampusHost = Properties.Settings.Default.CampusHost;
            string RequestURL = Properties.Settings.Default.RequestURL;
            string RequestHeader = Properties.Settings.Default.RequestHeader;
            string RequestData = Properties.Settings.Default.RequestData;
            try
            {
                //检查字符串是否为空
                if (CampusHost == ""||RequestURL ==""||RequestHeader==""||RequestData=="")
                {
                    return (int)status.Null;
                }
                //检查网络可用性
                if (!IsNetworkAvailability())
                {
                    return (int)status.UnConnected;
                }

                PingReply baiduReplay = await PingHostAsync(Properties.Settings.Default.BaiduHost);
                PingReply campusReply = await PingHostAsync(Properties.Settings.Default.CampusHost);

                if (baiduReplay.Status == IPStatus.Success && campusReply.Status == IPStatus.Success)
                {
                    return (int)status.Connected;
                }
                else if (campusReply.Status == IPStatus.Success)
                {
                    return (int)status.Wait;
                }
                else
                {
                    return (int)status.UnConnected;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 定时器
        /// </summary>
        /// 

        //public static void StartTimer()
        //{
        //    Timer timer = new Timer();
        //}

    }


}
