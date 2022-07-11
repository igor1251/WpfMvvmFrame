using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using WpfMvvmFrame.Messages;
using WpfMvvmFrame.Models;

namespace WpfMvvmFrame.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject, IRecipient<NewStudentMessage>
    {
        [ObservableProperty]
        ObservableCollection<Student> availableStudents = new ObservableCollection<Student>();

        [ICommand]
        void AddStudent()
        {
            WeakReferenceMessenger.Default.Send(new NewStudentMessage(Application.Current.MainWindow, AvailableStudents));
        }

        public void Receive(NewStudentMessage message)
        {
            MessageBox.Show(message.OperationResult);
        }

        public MainWindowViewModel()
        { 
            WeakReferenceMessenger.Default.Register<NewStudentMessage>(this);
        }
    }
}
