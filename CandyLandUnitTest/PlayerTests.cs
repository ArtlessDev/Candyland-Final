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
    public class PlayerTests
    {
        [TestMethod()]
        public void PlayerTest()
        {
            Player somePlayer = new Player();

            Assert.IsNotNull(somePlayer); // should construct a player object
            // all values should be either 0 or null
            Assert.AreEqual(0, somePlayer.Id);
            Assert.IsNull(somePlayer.Name);
            Assert.AreEqual(0, somePlayer.Position);
            Assert.AreEqual(0, somePlayer.Score);
        }

        [TestMethod()]
        public void PlayerTest1()
        {
            Player somePlayer = new Player(1, "jason", 5);

            Assert.IsNotNull(somePlayer);
            Assert.AreEqual(1, somePlayer.Id);
            Assert.AreNotEqual(0, somePlayer.Id);
            Assert.AreEqual("jason", somePlayer.Name);
            Assert.IsNotNull(somePlayer.Name);
            Assert.AreEqual(5, somePlayer.Position);
            Assert.AreNotEqual(0, somePlayer.Position);
        }
        [TestMethod()]
        public void IdTest()
        {
            Player somePlayer = new Player();
            int idTest = 1;
            int oldID = somePlayer.Id;

            Assert.IsTrue(somePlayer.Id is int);
            Assert.AreEqual(0, somePlayer.Id); // id should be 0 when first initialized
            Assert.AreNotEqual(idTest, somePlayer.Id);
            somePlayer.Id = 1;
            Assert.AreEqual(idTest, somePlayer.Id);
            Assert.AreNotEqual(oldID, somePlayer.Id);

            for (int i = 0; i < 4; i++)
            {
                Player p = new Player();
                p.Id = i;
                Assert.AreEqual(i, p.Id);
                Assert.IsNotNull(p.Id);
            }
        }
        [TestMethod()]
        public void NameTest()
        {
            Player somePlayer = new Player();

            Assert.IsNull(somePlayer.Name); // should be null on first init
            string testName = "jason";
            somePlayer.Name = testName;
            Assert.IsTrue(somePlayer.Name is string);

            Assert.IsNotNull(somePlayer.Name);
            somePlayer.Name = "jair";
            Assert.AreNotEqual(testName, somePlayer.Name);
        }
        [TestMethod()]
        public void PositionTest()
        {
            Player somePlayer = new Player();
            int testPosition = 7;
            int oldPosition = somePlayer.Position;

            Assert.AreEqual(0, somePlayer.Position);
            Assert.IsNotNull(somePlayer.Position);
            Assert.AreNotEqual(testPosition, somePlayer.Position);

            somePlayer.Position = testPosition;
            Assert.AreEqual(testPosition, somePlayer.Position);
            Assert.AreNotEqual(oldPosition, somePlayer.Position);
        }
        [TestMethod()]
        public void ScoreTest()
        {
            Player somePlayer = new Player();
            int oldScore = somePlayer.Score;

            Assert.IsTrue(somePlayer.Score is int);
            Assert.AreEqual(0, somePlayer.Score);
            Assert.IsNotNull(somePlayer.Score);

            somePlayer.Score = somePlayer.Score + 1;
            Assert.AreEqual(1, somePlayer.Score);
            Assert.AreNotEqual(oldScore, somePlayer.Score);

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum++;
                somePlayer.Score = i;
            }
            Assert.AreEqual(sum - 1, somePlayer.Score);
            Assert.AreNotEqual(oldScore, somePlayer.Score);
            Assert.IsNotNull(somePlayer.Score);
        }
    }
}