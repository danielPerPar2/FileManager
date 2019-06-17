using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common.Models
{
    public class Student
    {
        public Student() { }
        public Student(int id, string name, string surname, DateTime dateOfBirth)
        {
            StudentId = id;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Student otherStudent = (Student)obj;
            return this.Name == otherStudent.Name
                && this.Surname == otherStudent.Surname
                && this.DateOfBirth == otherStudent.DateOfBirth;    
        }

        public override int GetHashCode()
        {
            string nameSurnameBirth = Name + Surname + DateOfBirth.Day.ToString();
            return nameSurnameBirth.GetHashCode();
        }
    }
}
