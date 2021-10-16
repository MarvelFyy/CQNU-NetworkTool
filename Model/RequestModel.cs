using NetworkTool.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetworkTool.Model
{

    public class RequestModel : NotifyPropertyBase
    {

        private string _url;

        public string URL
        {
            get { return _url; }
            set
            {
                _url = value;
                this.DoNotify();
                string str = Regex.Match(URL, Function.urlPattern).Value;
                if (str=="")
                {
                    Function.URL = URL;
                }
                else
                {
                    Function.URL = str;
                }
            }
        }

        private string _header;

        public string Header
        {
            get { return _header; }
            set
            {
                _header = value;
                this.DoNotify();
                Function.headers.Clear();
                Function.FormatHandle(Header, Function.headers);
            }
        }

        private string _data;

        public string Data
        {
            get { return _data; }
            set
            {
                _data = value;
                this.DoNotify();
                Function.data.Clear();
                Function.FormatHandle(Data, Function.data);
            }
        }

        private int _cornerRadius;

        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            { 
                _cornerRadius = value;
                this.DoNotify();
            }
        }

    }

}
