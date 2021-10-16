using NetworkTool.Common;
using NetworkTool.Model;
using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NetworkTool.ViewModel
{
    class PortalViewModel
    {

        public PortalModel PortalModel { get; set; }

        /// <summary>
        /// Open URL 命令
        /// </summary>
        public CommandBase OpenURLCommand { get; set; }

        public string TempURL { get; set; }

        public PortalViewModel()
        {
            this.PortalModel = new PortalModel();
            this.PortalModel.CornerRadius = Properties.Settings.Default.CornerRadius;
            TempURL = Properties.Settings.Default.CampusHost;
            PortalModel.CampusURL =TempURL;

            //打开校园网
            this.OpenURLCommand = new CommandBase();
            this.OpenURLCommand.DoExecute = new Action<object>(async (o) =>
            {
                Process.Start(@"http://"+PortalModel.CampusURL);

                if (PortalModel.CampusURL!=TempURL)
                {   
                    TempURL = PortalModel.CampusURL;
                    Properties.Settings.Default.CampusHost = TempURL;
                    Properties.Settings.Default.Save();
                }
            });
            this.OpenURLCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }
    }
}
