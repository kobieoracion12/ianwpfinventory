﻿#pragma checksum "..\..\..\windows\win_price Check.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2F7819F57E25675CA236C861C886E5503AA63B5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NavigationDrawerPopUpMenu2.windows;
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


namespace NavigationDrawerPopUpMenu2.windows {
    
    
    /// <summary>
    /// win_priceCheck
    /// </summary>
    public partial class win_priceCheck : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\windows\win_price Check.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock orderNo;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\windows\win_price Check.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox checkBarcode;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\windows\win_price Check.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox checkItem;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\windows\win_price Check.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox checkBrand;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\windows\win_price Check.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox checkStock;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\windows\win_price Check.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox checkPrice;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\windows\win_price Check.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox checkDOA;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\windows\win_price Check.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox checkStatus;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\windows\win_price Check.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button returnButton;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/windows/win_price%20check.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\win_price Check.xaml"
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
            this.orderNo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.checkBarcode = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\windows\win_price Check.xaml"
            this.checkBarcode.KeyDown += new System.Windows.Input.KeyEventHandler(this.checkBarcode_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.checkItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.checkBrand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.checkStock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.checkPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.checkDOA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.checkStatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.returnButton = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\windows\win_price Check.xaml"
            this.returnButton.Click += new System.Windows.RoutedEventHandler(this.returnButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
