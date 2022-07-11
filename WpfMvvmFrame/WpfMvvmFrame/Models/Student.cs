using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmFrame.Models
{
    public class Student : BaseEntity
    {
        public string Surname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
        public int Age { get; set; } = 0;

        public Student()
        {
            Surname = Name = Lastname = String.Empty;
            DateOfBirth = DateTime.MinValue;
            Age = (DateTime.Now - DateOfBirth).Days / 365;
        }

        public Student(string surname, string lastname, DateTime dateOfBirth, int age)
        {
            Surname = surname;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
            Age = age;
        }
    }
}
