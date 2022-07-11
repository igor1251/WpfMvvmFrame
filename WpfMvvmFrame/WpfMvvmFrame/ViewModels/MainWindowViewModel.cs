using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using WpfMvvmFrame.DialogWindows.VoidDialogWindow;
using WpfMvvmFrame.Messages;

namespace WpfMvvmFrame.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject, IRecipient<GreetMessage>, IRecipient<SimpleDialogMessage>
    {
        const string DECIMAL_NUMBER_VALIDATION_REGEX = @"^-?([0]{1}\.{1}[0-9]+|[1-9]{1}[0-9]*\.{1}[0-9]+|[0-9]+|0)$";

        [ObservableProperty]
        string stringBinding = string.Empty;

        [ObservableProperty]
        decimal decimalBinding = 0.0M;

        [ObservableProperty]
        ulong maskedBinding;

        string regexControlledBinding = string.Empty;
        public string RegexControlledBinding
        {
            get => regexControlledBinding;
            set
            {
                if (Regex.IsMatch(value, DECIMAL_NUMBER_VALIDATION_REGEX) || value == string.Empty)
                    SetProperty(ref regexControlledBinding, value);
            }
        }

        [ObservableProperty]
        bool canClick = true;

        [ICommand]
        void ClearFields()
        {
            StringBinding = string.Empty;
            DecimalBinding = 0.0M;
            MaskedBinding = 0;
            RegexControlledBinding = string.Empty;
        }

        [ICommand]
        void ChangeButtonCondition()
        {
            CanClick = !CanClick;
        }

        [ICommand]
        void ShowGreeting()
        {
            WeakReferenceMessenger.Default.Send(new GreetMessage());
        }

        [ICommand]
        void DemostrateChildWindow()
        {
            WeakReferenceMessenger.Default.Send(new SimpleDialogMessage(Application.Current.MainWindow, "Dialog window Demo"));
        }

        public void Receive(GreetMessage message)
        {
            MessageBox.Show("GreetMessage recieved!");
        }

        public void Receive(SimpleDialogMessage message)
        {
            MessageBox.Show("SimpleDialogMessage recieved!");
        }

        public MainWindowViewModel()
        {
            WeakReferenceMessenger.Default.Register<GreetMessage>(this);
            WeakReferenceMessenger.Default.Register<SimpleDialogMessage>(this);
        }
    }
}
