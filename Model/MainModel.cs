using NetworkTool.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NetworkTool.Model
{
    public class MainModel : NotifyPropertyBase
    {
        //默认未灰色 未连接
        private string _statusColor;

        public string StatusColor
        {
            get { return _statusColor; }
            set 
            { 
                _statusColor = value;
                this.DoNotify();
            }
        }

        //状态描述
        private string _statusDescription;

        public string StatusDescription
        {
            get { return _statusDescription; }
            set
            { 
                _statusDescription = value;
                this.DoNotify();
            }
        }

        private int _cornerRadius;

        public int CornerRadius
        {
            get { return _cornerRadius; }
            set { _cornerRadius = value; }
        }

    }
}
