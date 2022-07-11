using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMvvmFrame.Messages
{
    public class GreetMessage : ValueChangedMessage<string>
    {
        public GreetMessage(string message = "Works!") : base(message)
        {
            MessageBox.Show(message);
        }
    }
}
