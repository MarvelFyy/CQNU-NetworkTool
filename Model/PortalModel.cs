using NetworkTool.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkTool.Model
{
    class PortalModel: NotifyPropertyBase
    {
        private string _campusURL;

        public string CampusURL
        {
            get { return _campusURL; }
            set 
            { 
                _campusURL = value;
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
