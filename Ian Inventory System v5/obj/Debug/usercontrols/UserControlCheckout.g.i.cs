﻿#pragma checksum "..\..\..\usercontrols\UserControlCheckout.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6504D7391E5ED092FD0C8D52D39141604ED47051"
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
    /// UserControlCheckout
    /// </summary>
    public partial class UserControlCheckout : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\usercontrols\UserControlCheckout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock orderNo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\usercontrols\UserControlCheckout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPrdName;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\usercontrols\UserControlCheckout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox entrySearch;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\usercontrols\UserControlCheckout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewinVoice;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\usercontrols\UserControlCheckout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeStockOutBtn;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\usercontrols\UserControlCheckout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearStockOutBtn;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\usercontrols\UserControlCheckout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveStockOutBtn;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\usercontrols\UserControlCheckout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewProdBtn;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\usercontrols\UserControlCheckout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeQtyBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/usercontrols/usercontrolcheckout.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\usercontrols\UserControlCheckout.xaml"
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
            
            #line 10 "..\..\..\usercontrols\UserControlCheckout.xaml"
            ((NavigationDrawerPopUpMenu2.usercontrols.UserControlCheckout)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.orderNo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tbPrdName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.entrySearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\usercontrols\UserControlCheckout.xaml"
            this.entrySearch.KeyDown += new System.Windows.Input.KeyEventHandler(this.entrySearch_KeyDown);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\usercontrols\UserControlCheckout.xaml"
            this.entrySearch.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_OnPreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.listViewinVoice = ((System.Windows.Controls.ListView)(target));
            
            #line 79 "..\..\..\usercontrols\UserControlCheckout.xaml"
            this.listViewinVoice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listViewinVoice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.removeStockOutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\usercontrols\UserControlCheckout.xaml"
            this.removeStockOutBtn.Click += new System.Windows.RoutedEventHandler(this.removeStockOutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.clearStockOutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\usercontrols\UserControlCheckout.xaml"
            this.clearStockOutBtn.Click += new System.Windows.RoutedEventHandler(this.clearStockOutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.saveStockOutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\usercontrols\UserControlCheckout.xaml"
            this.saveStockOutBtn.Click += new System.Windows.RoutedEventHandler(this.saveStockOutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.viewProdBtn = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\usercontrols\UserControlCheckout.xaml"
            this.viewProdBtn.Click += new System.Windows.RoutedEventHandler(this.viewProdBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.changeQtyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\usercontrols\UserControlCheckout.xaml"
            this.changeQtyBtn.Click += new System.Windows.RoutedEventHandler(this.ChangeQty_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

