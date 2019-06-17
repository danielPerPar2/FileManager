using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileManager.Common.Models;
using System.Configuration;

namespace FileManager.DataAccess.DAO
{
    class WriterTxt : IWriter
    {
        public string FilePath { get; private set; }

        public WriterTxt()
        {
            string solutionFolderPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = ConfigurationManager.AppSettings["persistence_file_txt"];
            FilePath = solutionFolderPath + fileName;
        }

        public void WriteStudent(Student student)
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

        public void DeleteLastStudent()
        {
            IEnumerable<string> students = File.ReadLines(FilePath);
            List<string> studentsList = students.ToList();
            studentsList.RemoveAt(studentsList.Count - 1);
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(FilePath, false);
                foreach (string student in studentsList)
                {
                    writer.WriteLine(student);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Dispose();
            }
        }
    }
}
