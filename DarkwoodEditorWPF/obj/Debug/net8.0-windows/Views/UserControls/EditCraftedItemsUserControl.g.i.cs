﻿#pragma checksum "..\..\..\..\..\Views\UserControls\EditCraftedItemsUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C43B10AE0C7A225E34B70BA7A0DB1CC4D1588799"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DarkwoodEditorWPF.Views.UserControls;
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


namespace DarkwoodEditorWPF.Views.UserControls {
    
    
    /// <summary>
    /// EditCraftedItemsUserControl
    /// </summary>
    public partial class EditCraftedItemsUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\..\Views\UserControls\EditCraftedItemsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeBtn;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\Views\UserControls\EditCraftedItemsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\..\Views\UserControls\EditCraftedItemsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox recipeComBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DarkwoodEditorWPF;V1.0.0.0;component/views/usercontrols/editcrafteditemsusercont" +
                    "rol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\UserControls\EditCraftedItemsUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.closeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\..\Views\UserControls\EditCraftedItemsUserControl.xaml"
            this.closeBtn.Click += new System.Windows.RoutedEventHandler(this.closeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.recipeComBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
