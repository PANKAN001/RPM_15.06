#pragma checksum "..\..\NoExit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A8D41D3BE1AF4121C65D18B633A82F0FEEC1262E965899CA804AC28D111047DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MySuperPuperProject;
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


namespace MySuperPuperProject {
    
    
    /// <summary>
    /// NoExit
    /// </summary>
    public partial class NoExit : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\NoExit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Password1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\NoExit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\NoExit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Password2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\NoExit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButPokaz;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\NoExit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButSkryt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\NoExit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButVhod;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\NoExit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButReg;
        
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
            System.Uri resourceLocater = new System.Uri("/MySuperPuperProject;component/noexit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NoExit.xaml"
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
            this.Password1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.Password2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ButPokaz = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\NoExit.xaml"
            this.ButPokaz.Click += new System.Windows.RoutedEventHandler(this.ButPokaz_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButSkryt = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\NoExit.xaml"
            this.ButSkryt.Click += new System.Windows.RoutedEventHandler(this.ButSkryt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButVhod = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\NoExit.xaml"
            this.ButVhod.Click += new System.Windows.RoutedEventHandler(this.Brn_Vhod_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButReg = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\NoExit.xaml"
            this.ButReg.Click += new System.Windows.RoutedEventHandler(this.Reg_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

