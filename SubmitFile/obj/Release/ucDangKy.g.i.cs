﻿#pragma checksum "..\..\ucDangKy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D3BABEF429B7295FFC488C0EBDA8F9EE672EF2DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubmitFile;
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


namespace SubmitFile {
    
    
    /// <summary>
    /// ucDangKy
    /// </summary>
    public partial class ucDangKy : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\ucDangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTenDau;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ucDangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTenCuoi;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ucDangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDkyTaiKhoan;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\ucDangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtDkyPass;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\ucDangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDangKyDB;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\ucDangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTroVe;
        
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
            System.Uri resourceLocater = new System.Uri("/SubmitFile;component/ucdangky.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ucDangKy.xaml"
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
            this.txtTenDau = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtTenCuoi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtDkyTaiKhoan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtDkyPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.btnDangKyDB = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\ucDangKy.xaml"
            this.btnDangKyDB.Click += new System.Windows.RoutedEventHandler(this.BtnDangKyDB_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnTroVe = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\ucDangKy.xaml"
            this.btnTroVe.Click += new System.Windows.RoutedEventHandler(this.BtnTroVe_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
