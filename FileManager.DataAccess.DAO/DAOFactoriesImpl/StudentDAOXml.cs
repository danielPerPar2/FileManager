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

            Student readStudent = FindById(student.StudentId);
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

        public Student FindById(int id)
        {
            var student = from element in xDocument.Element("students").Elements()
                          where element.Element("id").Value.Equals(id.ToString())
                          select element;
            if (student == null)
            {
                return null;
            }
            XElement found = GetFirstElement(student);
            string name = found.Element("name").Value;
            string surname = found.Element("surname").Value;
            DateTime dateOfBirth = Convert.ToDateTime(found.Element("dateOfBirth").Value);
            return new Student(id, name, surname, dateOfBirth);
        }

        private XElement GetFirstElement(IEnumerable<XElement> elements)
        {
            try
            {
                return elements.First();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }
        public Student Update(int id, Student updatedStudent)
        {
            throw new NotImplementedException();
        }
    }
}
