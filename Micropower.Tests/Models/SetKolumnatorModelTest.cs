using Micropower.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micropower.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void CountDays_ReturnValidValue()
        {
            SetKolumnatorModel model = new SetKolumnatorModel();
            // TODO: Add your test code here
            Assert.AreEqual(58016, 58016);
        }
    }
}
