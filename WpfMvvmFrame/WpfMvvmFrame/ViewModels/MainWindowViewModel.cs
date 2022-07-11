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

            /*
             * можно и просто через ShowDialog()
             * но так можно больше абстрагироваться от того, что происходит внутри вызова 
             * дочернего окна и от реализации этого окна, плюс, добавляется слушатель 
             * на результат исполнения вызова
             */ 
        }

        public void Receive(NewStudentMessage message)
        {
            if (!string.IsNullOrEmpty(message.OperationResult))
                MessageBox.Show(message.OperationResult);
        }

        public MainWindowViewModel()
        { 
            WeakReferenceMessenger.Default.Register<NewStudentMessage>(this);
        }
    }
}
