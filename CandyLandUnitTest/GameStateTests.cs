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
    public class GameStateTests
    {
        [TestMethod()]
        public void GetFarthestPlayerTest()
        {
            GameState gameState = new GameState();
            Player player1 = new Player(1, "jason", 0);
            Player player2 = new Player(2, "jair", 5);
            Player player3 = new Player(3, "zamir", 14);
            Player player4 = new Player(4, "jess", 7);
            Player[] playerList = { player1, player2, player3, player4 };
            gameState.Players = playerList;

            Assert.AreEqual(player1.GetType(), gameState.GetFarthestPlayer().GetType()); // returns Player type
            Assert.IsNotNull(gameState.GetFarthestPlayer().GetType());

            // farthest player is player3 with position 14
            Assert.AreEqual(player3.Name, gameState.GetFarthestPlayer().Name);
            Assert.IsNotNull(gameState.GetFarthestPlayer());
            Assert.AreNotEqual(player1.Name, gameState.GetFarthestPlayer().Name);

            // change player1's position to be highest
            player1.Position = 20;
            Assert.AreEqual(player1.Name, gameState.GetFarthestPlayer().Name);
            Assert.AreNotEqual(player3.Name, gameState.GetFarthestPlayer().Name);
            Assert.IsNotNull(gameState.GetFarthestPlayer());
        }

        [TestMethod()]
        public void RotateTurnsTest()
        {
            GameState gameState = new GameState();
            int initialCount = 1;
            int playerCount = 4;

            Assert.AreEqual(initialCount, gameState.CurrentTurn); // current turn always is 1 when gameState is initialized
            Assert.IsNotNull(gameState.CurrentTurn);
            Assert.AreNotEqual(playerCount, gameState.CurrentTurn);

            gameState.RotateTurns(playerCount);
            Assert.AreEqual(initialCount + 1, gameState.CurrentTurn); // when called once, should update currentTurn by 1, as long as currentTurn does not exceed player count
            Assert.AreNotEqual(initialCount, gameState.CurrentTurn);

            // rotate 2 more times
            gameState.RotateTurns(playerCount);
            gameState.RotateTurns(playerCount);

            initialCount = 4;
            Assert.AreEqual(initialCount, gameState.CurrentTurn);
            Assert.AreEqual(playerCount, gameState.CurrentTurn);

            // rotate one more time
            gameState.RotateTurns(playerCount);
            initialCount = 1;
            Assert.AreEqual(initialCount, gameState.CurrentTurn); // currentTurn should be back to 1
            Assert.AreNotEqual(playerCount, gameState.CurrentTurn);
        }
        [TestMethod()]
        public void PlayersTest()
        {
            GameState gameState = new GameState();
            Player player1 = new Player(1, "jason", 0);
            Player player2 = new Player(2, "jair", 5);
            Player player3 = new Player(3, "zamir", 14);
            Player player4 = new Player(4, "jess", 7);
            Player[] playerList = { player1, player2, player3, player4 };
            gameState.Players = playerList;

            Assert.AreEqual(playerList.GetType(), gameState.Players.GetType()); // returns array of players type
            Assert.IsNotNull(gameState.Players);

            for (int i = 0; i < playerList.Length; i++)
            {
                Assert.AreEqual(playerList[i].Id, gameState.Players[i].Id);
                Assert.AreEqual(playerList[i].Name, gameState.Players[i].Name);
                Assert.AreEqual(playerList[i].Position, gameState.Players[i].Position);
                Assert.IsNotNull(gameState.Players[i]);
            }
        }
    }
}