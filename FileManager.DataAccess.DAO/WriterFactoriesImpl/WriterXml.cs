using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using FileManager.Common.Models;
using FileManager.Utilities;

namespace FileManager.DataAccess.DAO.WriterFactoriesImpl
{
    class WriterXml : IWriter
    {
        private XDocument xDocument = null;
        
        public string FilePath { get; private set; }

        public WriterXml()
        {
            string solutionFolderPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = ConfigurationManager.AppSettings["persistence_file_xml"];
            FilePath = solutionFolderPath + fileName;
        }
        public void WriteStudent(Student student)
        {
            if (!File.Exists(FilePath))
            {
                xDocument = CreateNewDocument(); 
            }

            xDocument = XDocument.Load(FilePath);
            XElement root = xDocument.Element("students");
            XElement studentElement = CreateStudentElement(student);
            root.Add(studentElement);
                
            xDocument.Save(FilePath);
        }

        private XDocument CreateNewDocument()
        {
            XDocument xDocument = new XDocument(new XElement("students", ""));
            xDocument.Save(FilePath);
            return xDocument;
        }

        private XElement CreateStudentElement(Student student)
        {
            XElement studentElement = new XElement("student", "");
            studentElement.Add(
                new XElement("id", student.StudentId),
                new XElement("name", student.Name),
                new XElement("surname", student.Surname),
                new XElement("dateOfBirth", DateUtilities.DateTimeToStringES(student.DateOfBirth)));

            return studentElement;
        }

        public void DeleteLastStudent()
        {
            throw new NotImplementedException();
        }
    }
}
