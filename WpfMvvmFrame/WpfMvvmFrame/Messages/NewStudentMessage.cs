using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfMvvmFrame.DialogWindows.AddStudent;
using WpfMvvmFrame.Models;

namespace WpfMvvmFrame.Messages
{
    public class NewStudentMessage : ValueChangedMessage<ObservableCollection<Student>>
    {
        public string OperationResult = string.Empty;

        public NewStudentMessage(Window owner, ObservableCollection<Student> students) : base(students)
        {
            try
            {
                var addStudent = new AddStudentWindow(owner);

                var dialogResult = addStudent.ShowDialog();

                if (dialogResult.HasValue)
                {
                    if (dialogResult.Value)
                    {
                        students.Add(((AddStudentViewModel)addStudent.DataContext).Student);
                        OperationResult = "Successfully added!";
                    }
                }
            }
            catch (Exception ex)
            {
                OperationResult = ex.Message;
            }
        }
    }
}
