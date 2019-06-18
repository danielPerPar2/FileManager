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
            Student readStudent = FindById(student.StudentId);
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
        public Student FindById(int id)
        {
            List<string> lines = File.ReadLines(FilePath).ToList<string>();
            foreach(string line in lines)
            {
                string[] splitLine = line.Split(new char[] { ',' });
                int parsedId = ParseString(splitLine[0]);
                if(parsedId == id)
                {
                    string name = splitLine[1];
                    string surname = splitLine[2];
                    string dateString = splitLine[3];
                    DateTime dateOfBirth = ConvertFromString(dateString);
                    return new Student(id, name, surname, dateOfBirth);
                }               
            }
            return null;
        }

        private int ParseString(string idString)
        {
            try
            {
                return Int32.Parse(idString);
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }

        private DateTime ConvertFromString(string dateString)
        {
            try
            {
                return Convert.ToDateTime(dateString);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }
        public Student Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
