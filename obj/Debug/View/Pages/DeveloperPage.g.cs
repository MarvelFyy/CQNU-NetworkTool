#pragma checksum "..\..\..\..\View\Pages\DeveloperPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B8C7E976C8CA7643242BC8BA4FDFACE45A807CB61CD467F308BE61C12A2CBADD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NetworkTool.View.Pages;
using NetworkTool.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace NetworkTool.View.Pages {
    
    
    /// <summary>
    /// DeveloperPage
    /// </summary>
    public partial class DeveloperPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\View\Pages\DeveloperPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse avatar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\Pages\DeveloperPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameLabel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\Pages\DeveloperPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label contactLabel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\Pages\DeveloperPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label codeLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NetworkTool;component/view/pages/developerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Pages\DeveloperPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.avatar = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 2:
            this.nameLabel = ((System.Windows.Controls.Label)(target));
            
            #line 29 "..\..\..\..\View\Pages\DeveloperPage.xaml"
            this.nameLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.nameLabel_MouseDown);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\View\Pages\DeveloperPage.xaml"
            this.nameLabel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.nameLabel_MouseEnter);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\..\View\Pages\DeveloperPage.xaml"
            this.nameLabel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.nameLabel_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.contactLabel = ((System.Windows.Controls.Label)(target));
            
            #line 44 "..\..\..\..\View\Pages\DeveloperPage.xaml"
            this.contactLabel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.contactLabel_MouseEnter);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\..\View\Pages\DeveloperPage.xaml"
            this.contactLabel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.contactLabel_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.codeLabel = ((System.Windows.Controls.Label)(target));
            
            #line 48 "..\..\..\..\View\Pages\DeveloperPage.xaml"
            this.codeLabel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.codeLabel_MouseEnter);
            
            #line default
            #line hidden
            
            #line 48 "..\..\..\..\View\Pages\DeveloperPage.xaml"
            this.codeLabel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.codeLabel_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

