using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManager.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.DataAccess.DAO.DAOFactoriesImpl;
using FileManager.Common.Models;
using FileManager.Utilities;

namespace FileManager.DataAccess.DAO.Tests
{
    [TestClass()]
    public class StudentDAOJsonTests
    {
        IAbstractStudentDAOFactory daoFactory = null;
        IAbstractStudentDAO studentDaoJson = null;

        [TestMethod()]
        public void StudentDAOJsonTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        [DataRow(0, "Carlos", "López", "01", "02", "2000")]
        public void AddTest(int id, string name, string surname, string day, string month, string year)
        {
            daoFactory = new StudentDAOFactory();
            studentDaoJson = daoFactory.CreateStudentDAOJson();
            string dateString = day + "/" + month + "/" + year;
            Student student = new Student(id, name, surname, DateUtilities.StringToDateTimeES(dateString));
            Student insertedStudent = studentDaoJson.Add(student);

            Assert.IsTrue(student.Equals(insertedStudent));
        }
    }
}