using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfMvvmFrame.DialogWindows.VoidDialogWindow
{
    /// <summary>
    /// Логика взаимодействия для VoidDialogWindow.xaml
    /// </summary>
    public partial class VoidDialogWindow : Window
    {
        public VoidDialogWindow(Window owner, string caption = "< your text here >")
        {
            InitializeComponent();
            this.Title = caption;
            this.Owner = owner;
        }
    }
}
