using Lierda.WPFHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NetworkTool
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        LierdaCracker cracker = new LierdaCracker();

        protected override void OnStartup(StartupEventArgs e)
        {
            cracker.Cracker(30);//垃圾回收间隔时间
            base.OnStartup(e);
        }
    }
}
