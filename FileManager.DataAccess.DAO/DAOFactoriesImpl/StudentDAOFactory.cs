using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.DAO.DAOFactoriesImpl
{
    public class StudentDAOFactory : IAbstractStudentDAOFactory
    {
        public IAbstractStudentDAO CreateStudentDAOJson()
        {
            Console.WriteLine("Creating DAO Json");
            return new StudentDAOJson();
        }

        public IAbstractStudentDAO CreateStudentDAOTxt()
        {
            Console.WriteLine("Creating DAO Txt");
            return new StudentDAOTxt();
        }

        public IAbstractStudentDAO CreateStudentDAOXml()
        {
            Console.WriteLine("Creating DAO Xlm");
            return new StudentDAOXml();
        }
    }
}
