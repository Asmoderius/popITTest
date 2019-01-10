using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using gameEngine = Engine;

namespace Test
{

    [TestFixture]
    public class TestClass
    {
        private gameEngine.Engine e;

        [SetUp]
        public void Setup()
        {
            e = new gameEngine.Engine();
        }

        [Test]
        public void Case1_Test()
        {
            Assert.AreEqual(12, e.ThisWillFail(12));
        }

        [Test]
        public void Case2__Test()
        {
            Assert.AreEqual("Hello World!", e.ThisWillSucceed());
        }

        [Test]
        public void Case3_Test()
        {
            Assert.AreEqual(10, e.Calc(5, 2));
        }
    }
}
