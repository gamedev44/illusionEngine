﻿#pragma checksum "..\..\..\..\..\Editors\GeometryEditor\GeometryView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AB8EC836036336003FCC8889F5BCF71D12127651"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using illusionEditor.Editors;
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


namespace illusionEditor.Editors {
    
    
    /// <summary>
    /// GeometryView
    /// </summary>
    public partial class GeometryView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\Editors\GeometryEditor\GeometryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewport3D viewport;
        
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
            System.Uri resourceLocater = new System.Uri("/illusionEditor;component/editors/geometryeditor/geometryview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Editors\GeometryEditor\GeometryView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            
            #line 15 "..\..\..\..\..\Editors\GeometryEditor\GeometryView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OnGrid_Mouse_LBD);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\..\Editors\GeometryEditor\GeometryView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.OnGrid_MouseMove);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\..\..\Editors\GeometryEditor\GeometryView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnGrid_Mouse_LBU);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\..\..\Editors\GeometryEditor\GeometryView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.OnGrid_MouseWheel);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\..\..\Editors\GeometryEditor\GeometryView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OnGrid_Mouse_RBD);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\..\..\Editors\GeometryEditor\GeometryView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnGrid_Mouse_RBU);
            
            #line default
            #line hidden
            return;
            case 2:
            this.viewport = ((System.Windows.Controls.Viewport3D)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
