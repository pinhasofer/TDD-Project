using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void calcTest()
        {
            var temp = new Form1();
            int n1 = 3;
            int n2 = 4;
            int sum;
            int expSum = 7;

            sum = temp.calc(n1, n2);

            Assert.AreEqual(sum, expSum);

            //Assert.Fail();
        }
    }
}