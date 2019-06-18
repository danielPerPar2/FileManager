using FileManager.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.DAO
{
    public interface IAbstractStudentDAO
    {
        Student Add(Student student);

        Student FindById(int id);

        Student Update(int id);
    }
}
