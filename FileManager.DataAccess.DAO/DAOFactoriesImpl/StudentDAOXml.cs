using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FileManager.Common.Models;
using FileManager.Utilities;

namespace FileManager.DataAccess.DAO
{
    public class StudentDAOXml : IAbstractStudentDAO
    { 
        private XDocument xDocument = null;
        public string FilePath { get; private set; }

        public StudentDAOXml()
        {
            string solutionFolderPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = ConfigurationManager.AppSettings["persistence_file_xml"];
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
        private Student ReadStudent()
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

        private List<string> ReadStudentFields(XElement studentElement)
        {
            List<string> fields = new List<string>();
            foreach (XElement e in studentElement.Elements())
            {
                fields.Add(e.Value);
            }
            return fields;
        }
        private Student CreateStudentFromFields(List<string> fields)
        {
            int id = Int32.Parse(fields[0]);
            string name = fields[1];
            string surname = fields[2];
            DateTime dateOfBirth = DateUtilities.StringToDateTimeES(fields[3]);
            Student readStudent = new Student(id, name, surname, dateOfBirth);
            return readStudent;
        }

        public Student FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Student Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
