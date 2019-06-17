using FileManager.Common.Models;
using FileManager.DataAccess.DAO.ReaderFactories;
using FileManager.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.DAO.ReaderFactoriesImp
{
    public class ReaderTxt : IReader
    {
        public string FilePath { get; private set; }

        public ReaderTxt()
        {
            string solutionFolderPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = ConfigurationManager.AppSettings["persistence_file_txt"];
            FilePath = solutionFolderPath + fileName;
        }

        public Student ReadStudent()
        {
            string lastLine = File.ReadLines(FilePath).Last();
            string[] splitStudent = lastLine.Split(new char[] { ',' });            

            int id = Int32.Parse(splitStudent[0]);
            string name = splitStudent[1];
            string surname = splitStudent[2];
            DateTime dayOfBirth = DateUtilities.StringToDateTimeES(splitStudent[3]);
            Student student = new Student(id, name, surname, dayOfBirth);

            return student;
        }
    }
}
