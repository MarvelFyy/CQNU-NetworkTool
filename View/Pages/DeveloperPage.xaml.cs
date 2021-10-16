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
    /// Interaction logic for DeveloperPage.xaml
    /// </summary>
    public partial class DeveloperPage : Page
    {
        SolidColorBrush defaultForeground =new SolidColorBrush(Colors.Black);
        SolidColorBrush hoverForeground = new SolidColorBrush(Color.FromRgb(91, 127, 255));
        public DeveloperPage()
        {
            InitializeComponent();
        }

        private void nameLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://fuyanying.gitee.io/resume.io/");
        }

        //@Nice小夫
        private void nameLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            nameLabel.Foreground = hoverForeground;
        }

        private void nameLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            nameLabel.Foreground = defaultForeground;
        }

        //联系开发者
        private void contactLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            contactLabel.Foreground = hoverForeground;
        }

        private void contactLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            contactLabel.Foreground = defaultForeground;
        }

        //项目源代码
        private void codeLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            codeLabel.Foreground = hoverForeground;
        }

        private void codeLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            codeLabel.Foreground = defaultForeground;
        }

        private void codeLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://github.com/MarvelFyy/NetworkTool");
        }
    }
}
