using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SwapArray;
namespace Nunit1
{
    [TestFixture]
    public class LogicControl
    {
        [Test]
        public void ConstructorTest()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            Assert.IsNotNull(sa);
        }

        [Test]
        public void ComonWork()
        {
            string array = "0123456789";
            string etalon = "0673451289";
            string checkArray = null;
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            checkArray= sa.ProceedSwap(array, 1, 6, 2);
            Assert.AreEqual(etalon, checkArray);
        }

    }
    [TestFixture]
    public class DataIntroduction
    {
        [Test]
        public void InitialArray()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            string s = "asdfghjkl";
            sa.SetAr(s);
            Assert.AreEqual(sa.GetAr(),s);
        }
        [Test]
        public void Size_Valid()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");
            sa.SetSize("3",1);
            Assert.AreEqual(sa.GetSize(), 3);
        }
        [Test]
        [ExpectedException("System.Exception")]
        public void Size_Overrange()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");
            sa.SetSize("6",1);
        }
        [Test]
        [ExpectedException("System.Exception")]
        public void Size_CannotConvert()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");
            sa.SetSize("f",1);
        }
        [Test]
        [ExpectedException("System.Exception")]
        public void Size_WithoutArray()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetSize("1",1);
        }
        [Test]
        [ExpectedException("System.Exception")]
        public void I1_WithoutSize()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");
            sa.SetI1("1", 1);
        }
        [Test]
        [ExpectedException("System.Exception")]
        public void I1_Overrange()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");
            sa.SetSize("4");
            sa.SetI1("5", 1);
        }
        [Test]
        [ExpectedException("System.Exception")]
        public void I1_CannotConvert()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");
            sa.SetSize("4");
            sa.SetI1("t", 1);
        }
        [Test]
        public void I1_Valid()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");
            sa.SetSize("4");
            sa.SetI1("1", 1);
        }
        [Test]
        public void I2_Valid()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");
            sa.SetSize("4");
            sa.SetI1("1");
            sa.SetI2("5",1);
        }
        [Test]
        [ExpectedException("System.Exception")]
        public void I2_Overrange()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");
            sa.SetSize("4");
            sa.SetI1("1");
            sa.SetI2("3", 1);
        }
        [Test]
        [ExpectedException("System.Exception")]
        public void I2_CannotConvert()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");


            sa.SetSize("4");
            sa.SetI1("1");
            sa.SetI2("n", 1);
        }
        [Test]
        [ExpectedException("System.Exception")]
        public void I2_WithoutI1()
        {
            SwapArray.SwapArray sa = new SwapArray.SwapArray();
            sa.SetAr("asdfghjk");
            sa.SetSize("4");
            sa.SetI2("3", 1);
        }
    }
}
