﻿#pragma checksum "..\..\Stock.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D6E12D5F5FCF3F5968EAA7CA5311F2E97E6AF5A239A3E88A7DD6DCE42AF91D97"
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
    /// Stock
    /// </summary>
    public partial class Stock : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stock_piece;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stock_fournisseur;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stock_velo;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Menu;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stock_modele;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search1_txt;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stock_marque;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search2_txt;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gestion_stock_v;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gestion_stock_p;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Menu_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetBDD;component/stock.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Stock.xaml"
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
            this.stock_piece = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Stock.xaml"
            this.stock_piece.Click += new System.Windows.RoutedEventHandler(this.Stock_Pieces_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.stock_fournisseur = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Stock.xaml"
            this.stock_fournisseur.Click += new System.Windows.RoutedEventHandler(this.Stock_Fournisseur_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.stock_velo = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Stock.xaml"
            this.stock_velo.Click += new System.Windows.RoutedEventHandler(this.Stock_Velo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Menu = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Stock.xaml"
            this.Menu.Click += new System.Windows.RoutedEventHandler(this.Menu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.stock_modele = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Stock.xaml"
            this.stock_modele.Click += new System.Windows.RoutedEventHandler(this.stock_modele_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.search1_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.stock_marque = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Stock.xaml"
            this.stock_marque.Click += new System.Windows.RoutedEventHandler(this.stock_marque_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.search2_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.datagrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.gestion_stock_v = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Stock.xaml"
            this.gestion_stock_v.Click += new System.Windows.RoutedEventHandler(this.gestion_stock_v_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.gestion_stock_p = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Stock.xaml"
            this.gestion_stock_p.Click += new System.Windows.RoutedEventHandler(this.gestion_stock_p_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Menu_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Stock.xaml"
            this.Menu_Copy.Click += new System.Windows.RoutedEventHandler(this.Menu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
