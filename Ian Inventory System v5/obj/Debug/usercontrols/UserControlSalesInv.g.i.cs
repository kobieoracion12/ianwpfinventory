﻿#pragma checksum "..\..\..\usercontrols\UserControlSalesInv.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97FA17F651345BFEE876B8F29C9FADCE421FBC66"
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
    /// UserControlSalesInv
    /// </summary>
    public partial class UserControlSalesInv : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\usercontrols\UserControlSalesInv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchSort;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\usercontrols\UserControlSalesInv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exportData;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\usercontrols\UserControlSalesInv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exportSortedData;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\usercontrols\UserControlSalesInv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker sortCalendarFrom;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\usercontrols\UserControlSalesInv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker sortCalendarTo;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\usercontrols\UserControlSalesInv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sortBrand;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\usercontrols\UserControlSalesInv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sortButton;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\usercontrols\UserControlSalesInv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sortClear;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\usercontrols\UserControlSalesInv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewSales;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/usercontrols/usercontrolsalesinv.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\usercontrols\UserControlSalesInv.xaml"
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
            this.searchSort = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\usercontrols\UserControlSalesInv.xaml"
            this.searchSort.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchSort_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exportData = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\usercontrols\UserControlSalesInv.xaml"
            this.exportData.Click += new System.Windows.RoutedEventHandler(this.exportData_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.exportSortedData = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\usercontrols\UserControlSalesInv.xaml"
            this.exportSortedData.Click += new System.Windows.RoutedEventHandler(this.exportSortedData_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sortCalendarFrom = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.sortCalendarTo = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.sortBrand = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.sortButton = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\usercontrols\UserControlSalesInv.xaml"
            this.sortButton.Click += new System.Windows.RoutedEventHandler(this.sortButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.sortClear = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\usercontrols\UserControlSalesInv.xaml"
            this.sortClear.Click += new System.Windows.RoutedEventHandler(this.sortClear_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.listViewSales = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

