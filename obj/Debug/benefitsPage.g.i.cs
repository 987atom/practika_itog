﻿#pragma checksum "..\..\benefitsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B94B1C5D14576F2436C63C6F0CA442071B465B15B589CDA35EBE431E3AD49963"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PRAktika_itog;
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


namespace PRAktika_itog {
    
    
    /// <summary>
    /// benefitsPage
    /// </summary>
    public partial class benefitsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\benefitsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid benefitsGrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\benefitsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\benefitsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Del;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\benefitsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chang;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\benefitsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button To_Aviar;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\benefitsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx_Copy;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\benefitsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button to_users;
        
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
            System.Uri resourceLocater = new System.Uri("/PRAktika_itog;component/benefitspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\benefitsPage.xaml"
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
            this.benefitsGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 32 "..\..\benefitsPage.xaml"
            this.benefitsGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.animalsGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 33 "..\..\benefitsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NameTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Del = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\benefitsPage.xaml"
            this.Del.Click += new System.Windows.RoutedEventHandler(this.Del_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Chang = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\benefitsPage.xaml"
            this.Chang.Click += new System.Windows.RoutedEventHandler(this.Chang_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.To_Aviar = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\benefitsPage.xaml"
            this.To_Aviar.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NameTbx_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.to_users = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\benefitsPage.xaml"
            this.to_users.Click += new System.Windows.RoutedEventHandler(this.to_users_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

