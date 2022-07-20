using Data.Models;
using NUnit.Framework;

namespace MineTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var m = new Mine() {Id = "Armin5"};
            Assert.AreEqual("Armin5", m.Id);
        }
    }
}