﻿#pragma checksum "..\..\..\windows\window_addItem.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91122E2098B7F27547784EA0D436EBD551E932A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// window_addItem
    /// </summary>
    public partial class window_addItem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox checker;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbProdNo;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbProdItem;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tbProdBrand;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbProdQty;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbProdSRP;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbProdRP;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker tbProdDOA;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker tbProdEXPD;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addItemSubmit;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\windows\window_addItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addItemCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/windows/window_additem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\window_addItem.xaml"
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
            this.checker = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbProdNo = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\..\windows\window_addItem.xaml"
            this.tbProdNo.KeyDown += new System.Windows.Input.KeyEventHandler(this.tbProdNo_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbProdItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbProdBrand = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.tbProdQty = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbProdSRP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbProdRP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbProdDOA = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.tbProdEXPD = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.addItemSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\windows\window_addItem.xaml"
            this.addItemSubmit.Click += new System.Windows.RoutedEventHandler(this.addItemSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.addItemCancel = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\windows\window_addItem.xaml"
            this.addItemCancel.Click += new System.Windows.RoutedEventHandler(this.addItemCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

