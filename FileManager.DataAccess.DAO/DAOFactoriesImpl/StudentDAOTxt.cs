using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;
using FileManager.Utilities;

namespace FileManager.DataAccess.DAO
{
    public class StudentDAOTxt : IAbstractStudentDAO
    {     
        public string FilePath { get; private set; }
        public StudentDAOTxt()
        {
            string solutionFolderPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = ConfigurationManager.AppSettings["persistence_file_txt"];
            FilePath = solutionFolderPath + fileName;
        }
        public Student Add(Student student)
        {           
            WriteStudent(student);
            Student readStudent = ReadStudent();
            return readStudent;
        }       
        private void WriteStudent(Student student)
        {
            string line = student.StudentId + "," +
                            student.Name + "," +
                            student.Surname + "," +
                            student.DateOfBirth.Day.ToString() + "/" +
                            student.DateOfBirth.Month.ToString() + "/" +
                            student.DateOfBirth.Year.ToString();

            StreamWriter outputFile = null;
            WriteLine(outputFile, line);
        }
        private void WriteLine(StreamWriter outputFile, string line)
        {
            try
            {
                outputFile = new StreamWriter(FilePath, true);
                outputFile.WriteLine(line);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                outputFile.Dispose();
            }
        }
        private Student ReadStudent()
        {
            string lastLine = File.ReadLines(FilePath).Last();
            string[] splitStudent = lastLine.Split(new char[] { ',' });

            int id = Int32.Parse(splitStudent[0]);
            string name = splitStudent[1];
            string surname = splitStudent[2];
            DateTime dayOfBirth = DateUtilities.StringToDateTimeES(splitStudent[3]);
            Student student = new Student(id, name, surname, dayOfBirth);

            return student;
        }
    }
}
