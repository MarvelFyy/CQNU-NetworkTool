using NetworkTool.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NetworkTool.View.Pages
{
    /// <summary>
    ///  传送门 直达校园网页面
    /// </summary>
    public partial class PortalPage : Page
    {
        public PortalPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("http://10.0.251.18/");
        }
        /// <summary>
        /// 按下回车 传送到校园网
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyStates== Keyboard.GetKeyStates(Key.Return))
            {
                Process.Start("http://10.0.251.18/");
            }
        }
    }
}
