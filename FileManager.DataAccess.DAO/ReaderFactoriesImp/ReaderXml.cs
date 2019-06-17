using FileManager.Common.Models;
using FileManager.DataAccess.DAO.ReaderFactories;
using FileManager.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileManager.DataAccess.DAO.ReaderFactoriesImp
{
    public class ReaderXml : IReader
    {
        public string FilePath { get; private set; }

        public ReaderXml()
        {
            string solutionFolderPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = ConfigurationManager.AppSettings["persistence_file_xml"];
            FilePath = solutionFolderPath + fileName;
        }
        public Student ReadStudent()
        {
            XElement lastStudent = ReadLastStudentFromFile();
            List<string> fields = ReadStudentFields(lastStudent);
            Student readStudent = CreateStudentFromFields(fields);
            return readStudent;
        }

        private XElement ReadLastStudentFromFile()
        {
            XDocument doc = XDocument.Load(FilePath);
            XElement root = doc.Root;
            XElement lastStudent = root.Elements("student").Last();
            return lastStudent;
        }
        
        List<string> ReadStudentFields(XElement studentElement)
        {
            List<string> fields = new List<string>();
            foreach (XElement e in studentElement.Elements())
            {
                fields.Add(e.Value);
            }
            return fields;
        }

        Student CreateStudentFromFields(List<string> fields)
        {
            int id = Int32.Parse(fields[0]);
            string name = fields[1];
            string surname = fields[2];
            DateTime dateOfBirth = DateUtilities.StringToDateTimeES(fields[3]);
            Student readStudent = new Student(id, name, surname, dateOfBirth);
            return readStudent;
        }
    }
}
