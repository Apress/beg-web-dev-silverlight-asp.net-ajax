//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
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


namespace BlendProject1 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        internal BlendProject1.Window1 Window;
        
        internal System.Windows.Controls.DockPanel MainWindow;
        
        internal System.Windows.Controls.StackPanel DockTop;
        
        internal System.Windows.Controls.StackPanel DockBottom;
        
        internal System.Windows.Controls.StackPanel DockLeft;
        
        internal System.Windows.Controls.StackPanel DockRight;
        
        internal System.Windows.Controls.RichTextBox txtEdit;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BlendProject1;component/window1.xaml", System.UriKind.Relative);
            System.Windows.Application.LoadComponent(this, resourceLocater);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Window = ((BlendProject1.Window1)(target));
            return;
            case 2:
            this.MainWindow = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.DockTop = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.DockBottom = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.DockLeft = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.DockRight = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.txtEdit = ((System.Windows.Controls.RichTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}