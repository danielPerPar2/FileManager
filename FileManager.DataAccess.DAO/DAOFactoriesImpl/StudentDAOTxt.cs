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
    public class StudentDAOTxt : IAbstractStudentDAO, IStudentDAO
    {
        private WriterFactory writerFactoryTxt = null;
        private WriterTxt writerTxt = null;
        private ReaderFactory readerFactorytxt = null;
        private ReaderTxt readerTxt = null;

        public StudentDAOTxt()
        {
            writerFactoryTxt = new WriterFactory();
            writerTxt = (WriterTxt)writerFactoryTxt.CreateWriterTxt();
            readerFactorytxt = new ReaderFactory();
            readerTxt = (ReaderTxt)readerFactorytxt.CreateReaderTxt();
        }

        public Student Add(Student student)
        {
            Console.WriteLine("Adding student.txt");
            writerTxt.WriteStudent(student);

            Student readStudent = readerTxt.ReadStudent();
            return readStudent;
        }

        public void DeleteLastInsertedStudent()
        {
            writerTxt.DeleteLastStudent();
        }
    }
}
