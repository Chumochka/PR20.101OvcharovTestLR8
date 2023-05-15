using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestModulesLR8
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void task1_1_x10()
        {
            double x = 10;
            double expected = 10;

            TestLR8.MainClass main = new TestLR8.MainClass();
            double actual = main.task1_1(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void task1_1_x0()
        {
            double x = 0;
            double expected = 0;

            TestLR8.MainClass main = new TestLR8.MainClass();
            double actual = main.task1_1(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void task1_1_xminus2()
        {
            double x = -2;
            double expected = 3;

            TestLR8.MainClass main = new TestLR8.MainClass();
            double actual = main.task1_1(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void task1_2_5_and_3()
        {
            double a = 5;
            double b = 3;
            double[] expected = { 3,5 };

            TestLR8.MainClass main = new TestLR8.MainClass();
            double[] actual = main.task1_2(a,b);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void task2_1_10_3_6()
        {
            int a = 10;
            int b = 3;
            int c = 6;
            int expected = 10;

            TestLR8.MainClass main = new TestLR8.MainClass();
            int actual = main.task2_1(a,b,c);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void task2_1_3_10_6()
        {
            int a = 3;
            int b = 10;
            int c = 6;
            int expected = 10;

            TestLR8.MainClass main = new TestLR8.MainClass();
            int actual = main.task2_1(a, b, c);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void task2_1_6_3_10()
        {
            int a = 6;
            int b = 3;
            int c = 10;
            int expected = 10;

            TestLR8.MainClass main = new TestLR8.MainClass();
            int actual = main.task2_1(a, b, c);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void task2_2_325()
        {
            int a = 325;

            int[] expected = { 10,30};

            TestLR8.MainClass main = new TestLR8.MainClass();
            int[] actual = main.task2_2(a);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void task3_1_6()
        {
            int a = 6;
            int expected = 720;

            TestLR8.MainClass main = new TestLR8.MainClass();
            int actual = main.task3_1(a);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void task3_2_764580()
        {
            int a = 764580;
            int expected = 8;

            TestLR8.MainClass main = new TestLR8.MainClass();
            int actual = main.task3_2(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
