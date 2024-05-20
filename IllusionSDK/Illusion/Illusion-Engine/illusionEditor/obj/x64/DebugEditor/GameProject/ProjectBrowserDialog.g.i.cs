﻿#pragma checksum "..\..\..\..\GameProject\ProjectBrowserDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AD2DF30BCB326B46AC0A7459DED08A7CCCE55CC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using illusionEditor.GameProject;
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


namespace illusionEditor.GameProject {
    
    
    /// <summary>
    /// ProjectBrowserDialog
    /// </summary>
    public partial class ProjectBrowserDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\..\GameProject\ProjectBrowserDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\GameProject\ProjectBrowserDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle highlightRect;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\GameProject\ProjectBrowserDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton openProjectButton;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\GameProject\ProjectBrowserDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton createProjectButton;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\GameProject\ProjectBrowserDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel browserContent;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\GameProject\ProjectBrowserDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal illusionEditor.GameProject.OpenProjectView openProjectView;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\GameProject\ProjectBrowserDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal illusionEditor.GameProject.NewProjectView newProjectView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/illusionEditor;component/gameproject/projectbrowserdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GameProject\ProjectBrowserDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.highlightRect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.openProjectButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 96 "..\..\..\..\GameProject\ProjectBrowserDialog.xaml"
            this.openProjectButton.Click += new System.Windows.RoutedEventHandler(this.OnToggleButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.createProjectButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 98 "..\..\..\..\GameProject\ProjectBrowserDialog.xaml"
            this.createProjectButton.Click += new System.Windows.RoutedEventHandler(this.OnToggleButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.browserContent = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.openProjectView = ((illusionEditor.GameProject.OpenProjectView)(target));
            return;
            case 7:
            this.newProjectView = ((illusionEditor.GameProject.NewProjectView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

