using Microsoft.VisualStudio.TestTools.UnitTesting;
using Candyland_Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyland_Final.Tests
{
    [TestClass()]
    public class SpaceTests
    {
        [TestMethod()]
        public void SpaceTest()
        {
            string name = "i am the name of the square";
            int xCoordinate = 180;
            int yCoordinate = 268;
            Space spaceTest1 = new Space(name, xCoordinate, yCoordinate);

            Assert.AreEqual(name, spaceTest1.Square);
            Assert.AreEqual(xCoordinate, spaceTest1.XValue);
            Assert.AreEqual(yCoordinate, spaceTest1.YValue);
        }
        [TestMethod()]
        public void SquareTest()
        {
            string name1 = "i am the name of first square";
            string name2 = "i am the name of second square";
            string name3 = "i am the name of third square";
            Space spaceTest1 = new Space(name1, 100, 100);
            Space spaceTest2 = new Space(name2, 100, 100);
            Space spaceTest3 = new Space(name3, 100, 100);

            Assert.AreEqual(name1, spaceTest1.Square);
            Assert.AreEqual(name2, spaceTest2.Square);
            Assert.AreEqual(name3, spaceTest3.Square);

            spaceTest2.Square = spaceTest3.Square;
            Assert.AreEqual(name3, spaceTest2.Square);
        }
        [TestMethod()]
        public void XValueTest()
        {
            string name = "filler name";
            int xc1 = 100;
            int xc2 = 200;
            int xc3 = 300;
            Space spaceTest1 = new Space(name, xc1, 100);
            Space spaceTest2 = new Space(name, xc2, 100);
            Space spaceTest3 = new Space(name, xc3, 100);

            Assert.AreEqual(xc1, spaceTest1.XValue);
            Assert.AreEqual(xc2, spaceTest2.XValue);
            Assert.AreEqual(xc3, spaceTest3.XValue);

            spaceTest2.XValue = spaceTest3.XValue;
            Assert.AreEqual(xc3, spaceTest2.XValue);
        }
        [TestMethod()]
        public void YValueTest()
        {
            string name = "filler name";
            int yc1 = 100;
            int yc2 = 200;
            int yc3 = 300;
            Space spaceTest1 = new Space(name, 100, yc1);
            Space spaceTest2 = new Space(name, 100, yc2);
            Space spaceTest3 = new Space(name, 100, yc3);

            Assert.AreEqual(yc1, spaceTest1.YValue);
            Assert.AreEqual(yc2, spaceTest2.YValue);
            Assert.AreEqual(yc3, spaceTest3.YValue);

            spaceTest2.YValue = spaceTest3.YValue;
            Assert.AreEqual(yc3, spaceTest2.YValue);
        }
    }
}