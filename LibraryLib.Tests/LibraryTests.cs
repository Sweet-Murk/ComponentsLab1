using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryLib.Tests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void Search_ganre_fantasyReturned()
        {
            //Arrange
            string ganre = "fantasy";
            string expected = "Гарри Поттер";
            //Act
            Lib libtest = new Lib();
            string actual =libtest.PopularSearch(ganre);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Search_ganre_ScienceFailedReturned()
        {
            //Arrange
            string ganre = "science";
            string expected = "Гарри Поттер";
            //Act
            Lib libtest = new Lib();
            string actual = libtest.PopularSearch(ganre);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
