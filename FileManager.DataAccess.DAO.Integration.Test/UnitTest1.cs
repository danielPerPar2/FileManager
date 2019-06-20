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

        [TestMethod]
        public void TestVuelosSingletonWithStaticConstuctors()
        {
            //TODO: this static constructor singleton is not working. Fix this
            VuelosSingletonWithStaticConstructor vuelosSingletonsFirst = VuelosSingletonWithStaticConstructor.Instance;
            VuelosSingletonWithStaticConstructor vuelosSingletonsSecond = VuelosSingletonWithStaticConstructor.Instance;

            Assert.IsTrue(vuelosSingletonsFirst.Id.ToString() == vuelosSingletonsSecond.Id.ToString());
        }
    }
}
