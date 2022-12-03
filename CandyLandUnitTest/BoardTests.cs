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
    public class BoardTests
    {
        [TestMethod()]
        public void BoardTest()
        {
            Board board = new Board();

            Assert.IsNotNull(board);
        }

        [TestMethod()]
        public void GetLeftTest()
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Player player3 = new Player();
            Board board1 = new Board();

            int p1 = 0;
            int p2 = 10;
            int p3 = 34;

            player1.Position = p1;
            player2.Position = p2;
            player3.Position = p3;

            //returns the x value, thus we need to test for that value, not index position
            Assert.AreEqual(165, board1.GetLeft(player1));
            Assert.AreEqual(435, board1.GetLeft(player2));
            Assert.AreEqual(285, board1.GetLeft(player3));
        }

        [TestMethod()]
        public void GetTopTest()
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Player player3 = new Player();
            Board board1 = new Board();

            int p1 = 0;
            int p2 = 10;
            int p3 = 34;
            
            player1.Position = p1;
            player2.Position = p2;
            player3.Position = p3;

            //returns the y value, thus we need to test for that value, not index position
            Assert.AreEqual(100, board1.GetTop(player1));
            Assert.AreEqual(130, board1.GetTop(player2));
            Assert.AreEqual(220, board1.GetTop(player3));
        }

        [TestMethod()]
        public void GetNextSpaceTest()
        {
            Player player1 = new Player();
            Card card1 = new Card();
            Board board = new Board();

            int initialPosition = 8;
            int endPosition = 14;

            player1.Position = initialPosition;
            card1.CardType = "singleyellow";

            Assert.AreEqual(8, player1.Position);
            
            Assert.AreEqual(endPosition, board.GetNextSpace(ref player1, card1));
        }
    }
}