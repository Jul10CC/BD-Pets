﻿#pragma checksum "..\..\..\Mantenimientos\UserControlAnulacion.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AF85947283D2D63283E28803C6E37E1241082720"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UI.Mantenimientos;


namespace UI.Mantenimientos {
    
    
    /// <summary>
    /// UserControlAnulacion
    /// </summary>
    public partial class UserControlAnulacion : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelId;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextID;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAnular;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Detalle;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextEstado;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAnular_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/mantenimientos/usercontrolanulacion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
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
            this.labelId = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TextID = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
            this.TextID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonAnular = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
            this.buttonAnular.Click += new System.Windows.RoutedEventHandler(this.ButtonConfirmar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dataGrid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.Detalle = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.TextEstado = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.buttonAnular_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Mantenimientos\UserControlAnulacion.xaml"
            this.buttonAnular_Copy.Click += new System.Windows.RoutedEventHandler(this.ButtonAnular_Copy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
