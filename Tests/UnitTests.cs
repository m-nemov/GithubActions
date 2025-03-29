using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GithubActionsLab.Tests
{
    [TestClass]
    public class UnitTests
    {
        // --- ADD ---
        [TestMethod]
        public void Add_Valid_Nemov()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(10, Program.Add("5", "5"));
        }

        [TestMethod]
        public void Add_Invalid_Nemov()
        {
            Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        }

        [TestMethod]
        public void Add_Null_Nemov()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
        }

        // --- SUBTRACT ---
        [TestMethod]
        public void Subtract_Valid_Nemov()
        {
            Assert.AreEqual(2, Program.Subtract("5", "3"));
            Assert.AreEqual(0, Program.Subtract("4", "4"));
        }

        [TestMethod]
        public void Subtract_Invalid_Nemov()
        {
            Assert.ThrowsException<FormatException>(() => Program.Subtract("x", "2"));
            Assert.ThrowsException<FormatException>(() => Program.Subtract("2", "y"));
        }

        [TestMethod]
        public void Subtract_Null_Nemov()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        }

        // --- MULTIPLY ---
        [TestMethod]
        public void Multiply_Valid_Nemov()
        {
            Assert.AreEqual(6, Program.Multiply("2", "3"));
        }

        [TestMethod]
        public void Multiply_Invalid_Nemov()
        {
            Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "b"));
        }

        [TestMethod]
        public void Multiply_Null_Nemov()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
        }

        // --- DIVIDE ---
        [TestMethod]
        public void Divide_Valid_Nemov()
        {
            Assert.AreEqual(2, Program.Divide("4", "2"));
        }

        [TestMethod]
        public void Divide_Invalid_Nemov()
        {
            Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
        }

        [TestMethod]
        public void Divide_Zero_Nemov()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Program.Divide("4", "0"));
        }

        [TestMethod]
        public void Divide_Null_Nemov()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
        }

        // --- POWER ---
        [TestMethod]
        public void Power_Valid_Nemov()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(1, Program.Power("5", "0"));
        }

        [TestMethod]
        public void Power_Invalid_Nemov()
        {
            Assert.ThrowsException<FormatException>(() => Program.Power("two", "three"));
        }

        [TestMethod]
        public void Power_Null_Nemov()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
        }
    }
}

