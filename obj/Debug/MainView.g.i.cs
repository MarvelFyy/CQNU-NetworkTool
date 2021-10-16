﻿#pragma checksum "..\..\MainView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1B3729A9BA0D37D5613AD8B29D393430DE5608EDD9DC742741F0EAF389304C47"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NetworkTool;
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


namespace NetworkTool {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NetworkTool.MainView home;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridMenu;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnMenu;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard HideStackPanel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard ShowStackPanel;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdHome;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdSounds;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdNotes;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdPayment;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRestore;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PagesNavigation;
        
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
            System.Uri resourceLocater = new System.Uri("/NetworkTool;component/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainView.xaml"
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
            this.home = ((NetworkTool.MainView)(target));
            return;
            case 2:
            
            #line 12 "..\..\MainView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.btnMenu = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 5:
            this.HideStackPanel = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 6:
            this.ShowStackPanel = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 7:
            this.rdHome = ((System.Windows.Controls.RadioButton)(target));
            
            #line 57 "..\..\MainView.xaml"
            this.rdHome.Click += new System.Windows.RoutedEventHandler(this.rdHome_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rdSounds = ((System.Windows.Controls.RadioButton)(target));
            
            #line 58 "..\..\MainView.xaml"
            this.rdSounds.Click += new System.Windows.RoutedEventHandler(this.rdSounds_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rdNotes = ((System.Windows.Controls.RadioButton)(target));
            
            #line 59 "..\..\MainView.xaml"
            this.rdNotes.Click += new System.Windows.RoutedEventHandler(this.rdNotes_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rdPayment = ((System.Windows.Controls.RadioButton)(target));
            
            #line 60 "..\..\MainView.xaml"
            this.rdPayment.Click += new System.Windows.RoutedEventHandler(this.rdPayment_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\MainView.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnRestore = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\MainView.xaml"
            this.btnRestore.Click += new System.Windows.RoutedEventHandler(this.btnRestore_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\MainView.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.PagesNavigation = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

