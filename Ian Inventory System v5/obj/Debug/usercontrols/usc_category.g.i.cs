﻿#pragma checksum "..\..\..\usercontrols\usc_category.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F9845AF98D224D1926BCEAB5B02553DA80060E0E"
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
    /// usc_category
    /// </summary>
    public partial class usc_category : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\usercontrols\usc_category.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\usercontrols\usc_category.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\usercontrols\usc_category.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeButton;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\usercontrols\usc_category.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox entrySearch;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\usercontrols\usc_category.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox itemCtg;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\usercontrols\usc_category.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewCategory;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\usercontrols\usc_category.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewBrowse;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/usercontrols/usc_category.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\usercontrols\usc_category.xaml"
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
            this.addButton = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.editButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.removeButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.entrySearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 77 "..\..\..\usercontrols\usc_category.xaml"
            this.entrySearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.entrySearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.itemCtg = ((System.Windows.Controls.TextBox)(target));
            
            #line 82 "..\..\..\usercontrols\usc_category.xaml"
            this.itemCtg.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.itemCtg_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listViewCategory = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.listViewBrowse = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

