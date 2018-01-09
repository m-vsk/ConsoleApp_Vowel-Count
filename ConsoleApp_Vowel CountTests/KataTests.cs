using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp_Vowel_Count;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Vowel_Count.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void GetVowelCountTest()
        {
            Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}