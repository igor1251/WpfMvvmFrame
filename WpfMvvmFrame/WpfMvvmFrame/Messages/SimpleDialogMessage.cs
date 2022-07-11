using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfMvvmFrame.DialogWindows.VoidDialogWindow;

namespace WpfMvvmFrame.Messages
{
    public class SimpleDialogMessage : ValueChangedMessage<string>
    {
        public SimpleDialogMessage(Window owner, string caption = "Test custom dialog window") : base (caption)
        {
            var voidWindow = new VoidDialogWindow(owner, caption);
            voidWindow.ShowDialog();
        }
    }
}
