using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfMvvmFrame.Models;

namespace WpfMvvmFrame.DialogWindows.AddStudent
{
    public partial class AddStudentViewModel : ObservableObject
    {
        [ObservableProperty]
        Student student = new();

        [ICommand]
        void Accept(Window window)
        {
            window.DialogResult = true;
        }

        [ICommand]
        void Decline(Window window)
        {
            window.DialogResult = false;
        }
    }
}
