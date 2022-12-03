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
    public class SquareTypeTests
    {
        [TestMethod()]
        public void ColorTypesTest()
        {
            string db = "doubleBlue",
            dg = "doubleGreen",
            dor = "doubleOrange",
            dp = "doublePurple",
            dr = "doubleRed",
            dy = "doubleYellow",
            sb = "singleBlue",
            sg = "singleGreen",
            so = "singleOrange",
            sp = "singlePurple",
            sr = "singleRed",
            sy = "singleYellow",
            spec = "special";

            Assert.AreEqual(db, SquareType.ColorTypes[0]);
            Assert.AreEqual(dg, SquareType.ColorTypes[1]);
            Assert.AreEqual(dor, SquareType.ColorTypes[2]);
            Assert.AreEqual(dp, SquareType.ColorTypes[3]);
            Assert.AreEqual(dr, SquareType.ColorTypes[4]);
            Assert.AreEqual(dy, SquareType.ColorTypes[5]);
            Assert.AreEqual(sb, SquareType.ColorTypes[6]);
            Assert.AreEqual(sg, SquareType.ColorTypes[7]);
            Assert.AreEqual(so, SquareType.ColorTypes[8]);
            Assert.AreEqual(sp, SquareType.ColorTypes[9]);
            Assert.AreEqual(sr, SquareType.ColorTypes[10]);
            Assert.AreEqual(sy, SquareType.ColorTypes[11]);
            Assert.AreEqual(spec, SquareType.ColorTypes[12]);
        }
        [TestMethod()]
        public void SpecialTypesTest()
        {
            string candyCane = "specialCandycane",
            donut = "specialDonut",
            generic = "specialGeneric",
            iceCream = "specialIcecream",
            lollipop = "specialLollipop";

            Assert.AreEqual(candyCane, SquareType.SpecialTypes[0]);
            Assert.AreEqual(donut, SquareType.SpecialTypes[1]);
            Assert.AreEqual(generic, SquareType.SpecialTypes[2]);
            Assert.AreEqual(iceCream, SquareType.SpecialTypes[3]);
            Assert.AreEqual(lollipop, SquareType.SpecialTypes[4]);

        }
    }
}