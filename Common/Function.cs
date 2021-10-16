using Panuon.UI.Silver;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NetworkTool.Common
{
    public static class Function
    {

        //正则表达式
        public const string allPattern = @".+";
        public const string keyPattern = @".+(?=: )";
        public const string valuePattern = @"(?<=: ).+";
        //public const string cookieNamePattern = @".+(?=;)";
        //public const string cookiePassPattern = @"(?<=; ).+";
        public const string urlPattern = @"(?<=URL: ).+";
        public const string finalPattern = @"[^\n|\r|\t]+";


        //请求信息
        public static string URL=null;
        public static Dictionary<string, string> headers = new Dictionary<string, string>();
        public static Dictionary<string, string> data = new Dictionary<string, string>();

        //设置圆角
        public const int win11Radius=4;
        public const int defaultRadius=0;



        //public static void SaveProfile(string path, string content)
        //{
        //    FileStream fs = new FileStream(path, FileMode.Create);
        //    StreamWriter sw = new StreamWriter(fs);
        //    sw.WriteLine(content);
        //    sw.Close();

        //}

        //public static string OpenProfile(string path)
        //{
        //    string content="";
        //    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
        //    StreamReader sr = new StreamReader(fs);
        //    //while ((line = sr.ReadLine()) != null)
        //    //{
        //    //    content += line + "\n";
        //    //}
        //    content=sr.ReadToEnd();
        //    sr.Close();
        //    return content;

        //}

        /// <summary>
        /// 利用正则表达式 处理请求信息
        /// </summary>
        public static async Task RequestInfoHandleAsync()
        {
            await Task.Run(() =>
            {
                string URL = Properties.Settings.Default.RequestURL;
                string Header = Properties.Settings.Default.RequestHeader;
                string Data = Properties.Settings.Default.RequestData;

                //URL处理
                string str = Regex.Match(URL, urlPattern).Value;
                if (str == "")
                {
                    Function.URL = URL;
                }
                else
                {
                    Function.URL = str;
                }
                FormatHandle(Header, headers);
                FormatHandle(Data, data);
            });

        }

        /// <summary>
        /// 使用正则表达式对字符串进行处理
        /// </summary>
        public static void FormatHandle(string str, Dictionary<string, string> dict)
        {
            try
            {
                foreach (Match match in Regex.Matches(str, allPattern))
                {
                    string match_key = Regex.Match(match.Value, keyPattern).Value;
                    string temp = Regex.Match(match.Value, valuePattern).Value;
                    string match_value = Regex.Match(temp, finalPattern).Value;
                    dict.Add(match_key, match_value);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static async Task<IRestResponse> SendRequestAsync()
        {
            try
            {
                return await Task.Run(() =>
                {
                    RestClient client = new RestClient(URL);
                    RestRequest request = new RestRequest(Method.POST);
                    request.AddHeaders(headers);
                    //x-www-form-urlencoded
                    foreach (var item in data)
                    {
                        request.AddParameter(item.Key, item.Value);
                    }
                    var response = client.Post(request);
                    return response;
                });

            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
