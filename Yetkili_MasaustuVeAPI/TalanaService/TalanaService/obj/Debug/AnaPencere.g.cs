﻿#pragma checksum "..\..\AnaPencere.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F8322534E640B48DC2E3246DB0DC77D66411E26BC9481313F7E1523ECAC9D94"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
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
using TalanaService;
using TalanaService.Nesneler;


namespace TalanaService {
    
    
    /// <summary>
    /// AnaPencere
    /// </summary>
    public partial class AnaPencere : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\AnaPencere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserBtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AnaPencere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image SeraEkleBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AnaPencere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SeraListesi;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AnaPencere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label degisenBaslik;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\AnaPencere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame degisenPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/TalanaService;component/anapencere.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AnaPencere.xaml"
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
            
            #line 19 "..\..\AnaPencere.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UserBtn = ((System.Windows.Controls.Image)(target));
            
            #line 29 "..\..\AnaPencere.xaml"
            this.UserBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UserBtn_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SeraEkleBtn = ((System.Windows.Controls.Image)(target));
            
            #line 31 "..\..\AnaPencere.xaml"
            this.SeraEkleBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SeraEkle_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SeraListesi = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.degisenBaslik = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.degisenPanel = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
