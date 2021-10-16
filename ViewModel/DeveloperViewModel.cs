using NetworkTool.Common;
using NetworkTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetworkTool.ViewModel
{
    class DeveloperViewModel
    {
        public DeveloperModel DeveloperModel { get; set; }

        public CommandBase HoverLabelCommand { get; set; }

        public DeveloperViewModel()
        {
            this.DeveloperModel = new DeveloperModel();
            this.DeveloperModel.CornerRadius = Properties.Settings.Default.CornerRadius;
        }
    }
}
