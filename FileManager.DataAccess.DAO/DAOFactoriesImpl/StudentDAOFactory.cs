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
            return new StudentDAOJson();
        }

        public IAbstractStudentDAO CreateStudentDAOTxt()
        {            
            return new StudentDAOTxt();
        }

        public IAbstractStudentDAO CreateStudentDAOXml()
        {            
            return new StudentDAOXml();
        }
    }
}
