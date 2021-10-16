using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
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
using NetworkTool.Common;
using NetworkTool.View.Pages;
using NetworkTool.ViewModel;

namespace NetworkTool
{
    /// <summary>
    /// MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uri WelcomePage = new Uri("View/Pages/WelcomePage.xaml", UriKind.RelativeOrAbsolute);
        Uri RequestPage = new Uri("View/Pages/RequestPage.xaml", UriKind.RelativeOrAbsolute);
        Uri SettingPage = new Uri("View/Pages/SettingPage.xaml", UriKind.RelativeOrAbsolute);
        Uri PortalPage = new Uri("View/Pages/PortalPage.xaml", UriKind.RelativeOrAbsolute);
        Uri DeveloperPage = new Uri("View/Pages/DeveloperPage.xaml", UriKind.RelativeOrAbsolute);
        public  MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new MainViewModel();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight; //确保最大化不会遮挡任务栏
            Function.RequestInfoHandleAsync();
            //NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler();
            PagesNavigation.Navigate(WelcomePage);
            //实时监测网络状态
        }



        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// 移动窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void rdWelcome_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(WelcomePage);
        }

        private void rdPortal_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(PortalPage);
        }

        private void rdRequest_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(RequestPage);
        }

        private void rdSetting_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(SettingPage);
        }

        private void rdDeveloper_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(DeveloperPage);
        }
    }
}
