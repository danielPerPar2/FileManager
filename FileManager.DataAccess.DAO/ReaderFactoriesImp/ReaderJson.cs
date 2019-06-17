using FileManager.Common.Models;
using FileManager.DataAccess.DAO.ReaderFactories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.DAO.ReaderFactoriesImp
{
    public class ReaderJson : IReader
    {
        private JsonSerializerSettings settings = null;
        public string FilePath { get; private set; }

        public ReaderJson()
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
        public Student ReadStudent()
        {
            string jsonString = ReadJsonFile();
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonString, settings);
            Student student = students.Last<Student>();
            return student;
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
    }
}
