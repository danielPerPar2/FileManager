using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.DAO
{
    public interface IAbstractStudentDAOFactory
    {
        IAbstractStudentDAO CreateStudentDAOTxt();
        IAbstractStudentDAO CreateStudentDAOXml();
        IAbstractStudentDAO CreateStudentDAOJson();
    }
}
