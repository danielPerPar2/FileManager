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
    public class StudentDAOXmlTests
    {
        IAbstractStudentDAOFactory daoFactory = null;
        IAbstractStudentDAO studentDaoXml = null;

        [TestMethod()]
        public void StudentDAOXmlTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        [DataRow(0, "CarlosTest", "López", "01", "02", "2000")]
        public void AddTest(int id, string name, string surname, string day, string month, string year)
        {
            daoFactory = new StudentDAOFactory();
            studentDaoXml = daoFactory.CreateStudentDAOXml();
            string dateString = day + "/" + month + "/" + year;

            Student student = new Student(id, name, surname, DateUtilities.StringToDateTimeES(dateString));
            Student insertedStudent = studentDaoXml.Add(student);

            Assert.IsTrue(student.Equals(insertedStudent));
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}