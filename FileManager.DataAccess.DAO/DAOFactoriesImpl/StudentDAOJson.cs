using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;
using Newtonsoft.Json;

namespace FileManager.DataAccess.DAO
{
    public class StudentDAOJson : IAbstractStudentDAO
    {
        private JsonSerializerSettings settings = null;
        private const string emptyJsonArray = "[]";
        public string FilePath { get; private set; }

        public StudentDAOJson()
        {
            string solutionFolderPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = ConfigurationManager.AppSettings["persistence_file_json"];
            FilePath = solutionFolderPath + fileName;
            settings = new JsonSerializerSettings
            {
                DateFormatString = "dd'/'MM'/'yyyy",
                Formatting = Formatting.Indented
            };
        }

        public Student Add(Student student)
        {
            WriteStudent(student);
            Student readStudent = FindById(student.StudentId);
            return readStudent;
        }

        private void WriteStudent(Student student)
        {
            if (!File.Exists(FilePath))
            {
                InitializeJsonFile();
            }

            string jsonString = ReadJsonFile();
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonString, settings);
            students.Add(student);
            jsonString = JsonConvert.SerializeObject(students, settings);
            WriteJsonFile(jsonString);
        }
        private void InitializeJsonFile()
        {
            WriteJsonFile(emptyJsonArray);
        }
        private void WriteJsonFile(string jsonString)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(FilePath, false);
                writer.Write(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Dispose();
            }
        }
        private string ReadJsonFile()
        {
            string jsonString = String.Empty;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(FilePath);
                jsonString = reader.ReadToEnd();
                return jsonString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return String.Empty;
            }
            finally
            {
                reader.Close();
            }
        }

        public Student FindById(int id)
        {
            string jsonString = ReadJsonFile();
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonString, settings);
            foreach (Student student in students)
            {
                if (id == student.StudentId)
                {
                    return student;
                }
            }
            return null;
        }

        public Student Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
