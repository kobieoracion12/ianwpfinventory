﻿#pragma checksum "..\..\..\usercontrols\usc_inventory.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CCFCF5C816267DFA07631DD4853FBF8919BA291B"
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
    /// usc_inventory
    /// </summary>
    public partial class usc_inventory : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addItem;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button itemRequest;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button restockItem;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stockRequest;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker sortDOAfrom;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker sortDOAto;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sortBrand;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sortStatus;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sortButton;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refreshItem;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPrdId;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainSubColumn;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editItem;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\usercontrols\usc_inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteItem;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\usercontrols\usc_inventory.xaml"
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/usercontrols/usc_inventory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\usercontrols\usc_inventory.xaml"
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
            this.addItem = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\usercontrols\usc_inventory.xaml"
            this.addItem.Click += new System.Windows.RoutedEventHandler(this.addItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.itemRequest = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\usercontrols\usc_inventory.xaml"
            this.itemRequest.Click += new System.Windows.RoutedEventHandler(this.itemRequest_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.restockItem = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\usercontrols\usc_inventory.xaml"
            this.restockItem.Click += new System.Windows.RoutedEventHandler(this.restockItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.stockRequest = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.sortDOAfrom = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.sortDOAto = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.sortBrand = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.sortStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.sortButton = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\usercontrols\usc_inventory.xaml"
            this.sortButton.Click += new System.Windows.RoutedEventHandler(this.sortButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.refreshItem = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\usercontrols\usc_inventory.xaml"
            this.refreshItem.Click += new System.Windows.RoutedEventHandler(this.refreshItem_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.tbPrdId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.mainSubColumn = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.editItem = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\..\usercontrols\usc_inventory.xaml"
            this.editItem.Click += new System.Windows.RoutedEventHandler(this.editItem_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.deleteItem = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\..\usercontrols\usc_inventory.xaml"
            this.deleteItem.Click += new System.Windows.RoutedEventHandler(this.deleteItem_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.listViewInventory = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

