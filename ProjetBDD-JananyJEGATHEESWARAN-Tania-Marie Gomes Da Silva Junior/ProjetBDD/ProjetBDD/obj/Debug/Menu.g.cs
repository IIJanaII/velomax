﻿#pragma checksum "..\..\Menu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6272B8CCC4B74207E9DD4CEB90F7B61F303BD50C2A1E2E0A65B2EA3FD384179F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetBDD;
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


namespace ProjetBDD {
    
    
    /// <summary>
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clients_e;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clients_p;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pieces_rechange;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gestion_velos;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fournisseurs;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button commandes;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Statistiques;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetBDD;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu.xaml"
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
            this.clients_e = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Menu.xaml"
            this.clients_e.Click += new System.Windows.RoutedEventHandler(this.clients_e_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.clients_p = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Menu.xaml"
            this.clients_p.Click += new System.Windows.RoutedEventHandler(this.clients_p_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pieces_rechange = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Menu.xaml"
            this.pieces_rechange.Click += new System.Windows.RoutedEventHandler(this.pieces_rechange_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gestion_velos = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Menu.xaml"
            this.gestion_velos.Click += new System.Windows.RoutedEventHandler(this.gestion_velos_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.fournisseurs = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Menu.xaml"
            this.fournisseurs.Click += new System.Windows.RoutedEventHandler(this.fournisseurs_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.commandes = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Menu.xaml"
            this.commandes.Click += new System.Windows.RoutedEventHandler(this.commandes_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Statistiques = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Menu.xaml"
            this.Statistiques.Click += new System.Windows.RoutedEventHandler(this.Statistiques_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 18 "..\..\Menu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Stock_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 19 "..\..\Menu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exportation_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
