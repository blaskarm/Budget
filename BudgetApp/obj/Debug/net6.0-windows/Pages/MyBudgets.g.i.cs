﻿#pragma checksum "..\..\..\..\Pages\MyBudgets.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E4C0950A7E87BA0190C173212180E6BC6484A304"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BudgetApp.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace BudgetApp.Pages {
    
    
    /// <summary>
    /// MyBudgets
    /// </summary>
    public partial class MyBudgets : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Pages\MyBudgets.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox budgetsListbox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Pages\MyBudgets.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeBudgetButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\MyBudgets.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button selectBudgetCutton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BudgetApp;component/pages/mybudgets.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MyBudgets.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.budgetsListbox = ((System.Windows.Controls.ListBox)(target));
            
            #line 32 "..\..\..\..\Pages\MyBudgets.xaml"
            this.budgetsListbox.IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.budgetsListbox_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.removeBudgetButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Pages\MyBudgets.xaml"
            this.removeBudgetButton.Click += new System.Windows.RoutedEventHandler(this.removeBudgetButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.selectBudgetCutton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Pages\MyBudgets.xaml"
            this.selectBudgetCutton.Click += new System.Windows.RoutedEventHandler(this.selectBudgetCutton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

