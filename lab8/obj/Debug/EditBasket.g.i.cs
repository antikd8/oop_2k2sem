﻿#pragma checksum "..\..\EditBasket.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B60447EF7B421488725A5D3341CE1BC7B8FB6BC43935D88E575D69091A3ACD7E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using lab6_7;


namespace lab6_7 {
    
    
    /// <summary>
    /// EditBasket
    /// </summary>
    public partial class EditBasket : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 54 "..\..\EditBasket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBrowseHome;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\EditBasket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LabelMenu;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\EditBasket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOutputBasket;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\EditBasket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEditBasket;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\EditBasket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddGood;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\EditBasket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEN;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\EditBasket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRU;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\EditBasket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxThemes;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\EditBasket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewTable;
        
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
            System.Uri resourceLocater = new System.Uri("/lab6-7;component/editbasket.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditBasket.xaml"
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
            this.ButtonBrowseHome = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.LabelMenu = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ButtonOutputBasket = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\EditBasket.xaml"
            this.ButtonOutputBasket.Click += new System.Windows.RoutedEventHandler(this.ButtonOutputBasket_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonEditBasket = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.ButtonAddGood = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.ButtonEN = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\EditBasket.xaml"
            this.ButtonEN.Click += new System.Windows.RoutedEventHandler(this.ButtonEN_click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonRU = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\EditBasket.xaml"
            this.ButtonRU.Click += new System.Windows.RoutedEventHandler(this.ButtonRU_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ComboBoxThemes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.ListViewTable = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 132 "..\..\EditBasket.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonEditItem_Click);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 141 "..\..\EditBasket.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonDeleteItem_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

