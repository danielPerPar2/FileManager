using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManager.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;
using FileManager.Utilities;
using FileManager.DataAccess.DAO.DAOFactoriesImpl;

namespace FileManager.DataAccess.DAO.Tests
{
    [TestClass()]
    public class StudentDAOTxtTests
    {
        IAbstractStudentDAOFactory daoFactory = null;
        IStudentDAO studentDaoTxt = null;

        [TestMethod()]
        public void StudentDAOTxtTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        [DataRow(0, "TestCarlos", "López", "01", "02", "2000")]
        public void AddTest(int id, string name, string surname, string day, string month, string year)
        {
            daoFactory = new StudentDAOFactory();
            studentDaoTxt = (StudentDAOTxt)daoFactory.CreateStudentDAOTxt();
            string dateString = day + "/" + month + "/" + year;

            //We can use Convert.ToDateTime(dateString) instead of the utility method StringToDateTimeES(dateString)
            Student student = new Student(id, name, surname, DateUtilities.StringToDateTimeES(dateString));
            Student insertedStudent = studentDaoTxt.Add(student);

            //We can use Assert.AreEqual(student, insertedStudent)
            Assert.IsTrue(student.Equals(insertedStudent));

            //A file Debugstudents.txt is generated in the test project - no need to delete the last inserted student.
            //studentDaoTxt.DeleteLastInsertedStudent();
        }
    }
}