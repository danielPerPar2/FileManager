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
    public class StudentDAOJson : IAbstractStudentDAO, IStudentDAO
    {
        private WriterFactory writerFactoryJson = null;
        private WriterJson writerJson = null;
        private ReaderFactory readerFactoryJson = null;
        private ReaderJson readerJson = null;

        public StudentDAOJson()
        {
            writerFactoryJson = new WriterFactory();
            writerJson = (WriterJson)writerFactoryJson.CreateWriterJson();
            readerFactoryJson = new ReaderFactory();
            readerJson = (ReaderJson)readerFactoryJson.CreateReaderJson();
        }

        public Student Add(Student student)
        {
            Console.WriteLine("Adding student.json");
            writerJson.WriteStudent(student);

            Student readStudent = readerJson.ReadStudent();
            return readStudent;
        }

        public void DeleteLastInsertedStudent()
        {
            throw new NotImplementedException();
        }
    }
}
