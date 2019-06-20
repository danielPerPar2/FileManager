using System;
using FileManager.DataAccess.DAO.Singletons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileManager.DataAccess.DAO.Integration.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVuelosSingleton()
        {
            VuelosSingleton vuelosSingletonsFirst = VuelosSingleton.Instance;
            VuelosSingleton vuelosSingletonsSecond = VuelosSingleton.Instance;

            Assert.IsTrue(vuelosSingletonsFirst.Id.ToString() == vuelosSingletonsSecond.Id.ToString());



        }
    }
}
