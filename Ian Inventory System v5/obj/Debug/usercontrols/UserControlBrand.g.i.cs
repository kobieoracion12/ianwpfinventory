﻿#pragma checksum "..\..\..\usercontrols\UserControlBrand.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833A490AF12E3DAA185808B641273CD221D96846"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using NavigationDrawerPopUpMenu2.usercontrols;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace NavigationDrawerPopUpMenu2.usercontrols {
    
    
    /// <summary>
    /// UserControlBrand
    /// </summary>
    public partial class UserControlBrand : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\usercontrols\UserControlBrand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid isHeader;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\usercontrols\UserControlBrand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\usercontrols\UserControlBrand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPrdId;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\usercontrols\UserControlBrand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refreshBtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\usercontrols\UserControlBrand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearBtn;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\usercontrols\UserControlBrand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeBtn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\usercontrols\UserControlBrand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editBtn;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\usercontrols\UserControlBrand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\usercontrols\UserControlBrand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewInventory;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/usercontrols/usercontrolbrand.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\usercontrols\UserControlBrand.xaml"
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
            this.isHeader = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 36 "..\..\..\usercontrols\UserControlBrand.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbPrdId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.refreshBtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\usercontrols\UserControlBrand.xaml"
            this.refreshBtn.Click += new System.Windows.RoutedEventHandler(this.refreshBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.clearBtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\usercontrols\UserControlBrand.xaml"
            this.clearBtn.Click += new System.Windows.RoutedEventHandler(this.clearBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.removeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\usercontrols\UserControlBrand.xaml"
            this.removeBtn.Click += new System.Windows.RoutedEventHandler(this.removeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.editBtn = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\usercontrols\UserControlBrand.xaml"
            this.editBtn.Click += new System.Windows.RoutedEventHandler(this.editBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\usercontrols\UserControlBrand.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.listViewInventory = ((System.Windows.Controls.ListView)(target));
            
            #line 78 "..\..\..\usercontrols\UserControlBrand.xaml"
            this.listViewInventory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listViewInventory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

