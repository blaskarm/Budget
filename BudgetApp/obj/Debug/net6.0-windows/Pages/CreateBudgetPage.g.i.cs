﻿#pragma checksum "..\..\..\..\Pages\CreateBudgetPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3CA3EA1DB85C10A019373FEF0A751EF195D63CB9"
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
    /// CreateBudgetPage
    /// </summary>
    public partial class CreateBudgetPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox typeOfIncomeTextbox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox incomeAmountTextbox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addIncomeButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox incomeListBox;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeIncomeButton;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameOfExpenseTextbox;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox expenseAmountTextbox;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addExpenseButton;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox expensesListBox;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeExpenseButton;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\..\Pages\CreateBudgetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveBudgetButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BudgetApp;component/pages/createbudgetpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\CreateBudgetPage.xaml"
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
            this.typeOfIncomeTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.incomeAmountTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\..\Pages\CreateBudgetPage.xaml"
            this.incomeAmountTextbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.incomeAmountTextbox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addIncomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Pages\CreateBudgetPage.xaml"
            this.addIncomeButton.Click += new System.Windows.RoutedEventHandler(this.addIncomeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.incomeListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.removeIncomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\Pages\CreateBudgetPage.xaml"
            this.removeIncomeButton.Click += new System.Windows.RoutedEventHandler(this.removeIncomeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.nameOfExpenseTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.expenseAmountTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 114 "..\..\..\..\Pages\CreateBudgetPage.xaml"
            this.expenseAmountTextbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.expenseAmountTextbox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.addExpenseButton = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\..\..\Pages\CreateBudgetPage.xaml"
            this.addExpenseButton.Click += new System.Windows.RoutedEventHandler(this.addExpenseButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.expensesListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.removeExpenseButton = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\..\..\Pages\CreateBudgetPage.xaml"
            this.removeExpenseButton.Click += new System.Windows.RoutedEventHandler(this.removeExpenseButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.saveBudgetButton = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\..\..\Pages\CreateBudgetPage.xaml"
            this.saveBudgetButton.Click += new System.Windows.RoutedEventHandler(this.saveBudgetButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

