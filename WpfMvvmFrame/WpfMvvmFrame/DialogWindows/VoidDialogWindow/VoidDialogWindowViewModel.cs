using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMvvmFrame.DialogWindows.VoidDialogWindow
{
    public partial class VoidDialogWindowViewModel : ObservableObject
    {
        [ICommand]
        void Accept(Window window)
        {
            window.DialogResult = true;
        }

        [ICommand]
        void Cancel(Window window)
        {
            window.DialogResult = false;
        }
    }
}
