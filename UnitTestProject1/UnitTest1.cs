using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Forfatter()
        
        {
            Bog bog = new Bog();
            bog.Forfatter = "K";
            

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Sidetal()
        {
            Bog bog = new Bog();
            bog.Sidetal = 1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Isbn13()
        {
           Bog bog = new Bog();
           bog.Isbn13 = "s";
        }
    }
}
