using NetworkTool.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkTool.Model
{
    class SettingModel: NotifyPropertyBase
    {
        private bool _boot;

        public bool Boot
        {
            get { return _boot; }
            set 
            { 
                _boot = value;
                this.DoNotify();
            }
        }

        private bool _link;

        public bool Link
        {
            get { return _link; }
            set 
            { 
                _link = value;
                this.DoNotify();
            }
        }

        private bool _shortcut;

        public bool Shortcut
        {
            get { return _shortcut; }
            set
            { 
                _shortcut = value;
                this.DoNotify();
            }
        }

        private bool _corner;

        public bool Corner
        {
            get 
            { 
                return _corner;
            }
            set 
            { 
                _corner = value;         
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
