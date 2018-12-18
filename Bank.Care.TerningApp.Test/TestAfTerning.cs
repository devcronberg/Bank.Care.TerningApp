using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Care.TerningApp.Test
{
    [TestClass]
    public class TestAfTerning
    {
        [TestMethod]
        public void TestOpretTerning()
        {

            for (int i = 0; i < 10; i++)
            {
                Kerne.Terning t = new Kerne.Terning(6);
                Assert.IsTrue(t.Værdi == 6);
            }


        }

        [TestMethod]
        public void TestOpretTerning2()
        {

            for (int i = 0; i < 100; i++)
            {
                Kerne.Terning t = new Kerne.Terning();
                Assert.IsTrue(t.Værdi >= 1 && t.Værdi <= 6);
            }


        }
    }
}
