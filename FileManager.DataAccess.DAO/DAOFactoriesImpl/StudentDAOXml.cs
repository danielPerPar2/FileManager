using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;
using FileManager.DataAccess.DAO.ReaderFactoriesImp;
using FileManager.DataAccess.DAO.WriterFactoriesImpl;

namespace FileManager.DataAccess.DAO
{
    public class StudentDAOXml : IAbstractStudentDAO, IStudentDAO
    {
        private WriterFactory writerFactoryXml = null;
        private WriterXml writerXml = null;
        private ReaderFactory readerFactoryXml = null;
        private ReaderXml readerXml = null;

        public StudentDAOXml()
        {
            writerFactoryXml = new WriterFactory();
            writerXml = (WriterXml)writerFactoryXml.CreateWriterXml();
            readerFactoryXml = new ReaderFactory();
            readerXml = (ReaderXml)readerFactoryXml.CreateReaderXml();
        }

        public Student Add(Student student)
        {
            Console.WriteLine("Adding student.xml");
            writerXml.WriteStudent(student);

            Student readStudent = readerXml.ReadStudent();
            return readStudent;
        }

        public void DeleteLastInsertedStudent()
        {
            throw new NotImplementedException();
        }
    }
}
