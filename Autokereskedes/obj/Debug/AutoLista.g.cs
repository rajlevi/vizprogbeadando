﻿#pragma checksum "..\..\AutoLista.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A0FF82597CCFFAFB346D5553D6499799F7F8AF12FFFB3274A5B608C6E5A858A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Autokereskedes;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Autokereskedes {
    
    
    /// <summary>
    /// AutoLista
    /// </summary>
    public partial class AutoLista : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\AutoLista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MarkaTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AutoLista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EvjaratTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AutoLista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UzemanyagTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AutoLista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SzinTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AutoLista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KivitelTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AutoLista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button keresesBtn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AutoLista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ResultsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AutoLista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Autokereskedes;component/autolista.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AutoLista.xaml"
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
            this.MarkaTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\AutoLista.xaml"
            this.MarkaTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Kereses_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EvjaratTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\AutoLista.xaml"
            this.EvjaratTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Kereses_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UzemanyagTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\AutoLista.xaml"
            this.UzemanyagTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Kereses_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SzinTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\AutoLista.xaml"
            this.SzinTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Kereses_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.KivitelTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\AutoLista.xaml"
            this.KivitelTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Kereses_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.keresesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AutoLista.xaml"
            this.keresesBtn.Click += new System.Windows.RoutedEventHandler(this.keresesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ResultsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\AutoLista.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

