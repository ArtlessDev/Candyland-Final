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
    public class ScoreboardDBTests
    {
        [TestMethod()]
        public void GetAllScoresTest()
        {
            List<Player> somePlayers = new List<Player>();

            // ScoreboardDB.GetAllScores returns a list of past played players in the db

            Assert.AreEqual(somePlayers.GetType(), ScoreboardDB.GetAllScores().GetType()); // check if datatype is List<Player> type
            Assert.IsNotNull(ScoreboardDB.GetAllScores());

            // add some players to the db
            Player player1 = new Player();
            player1.Name = "bob";
            player1.Score = 2;
            ScoreboardDB.AddNewScore(player1);
            Player player2 = new Player();
            player2.Name = "tim";
            player2.Score = 7;
            ScoreboardDB.AddNewScore(player2);
            Player player3 = new Player();
            player3.Name = "joe";
            player3.Score = 4;
            ScoreboardDB.AddNewScore(player3);

            // check if the list of players is Player type
            foreach (Player p in ScoreboardDB.GetAllScores())
            {
                Assert.AreEqual(player1.GetType(), p.GetType());
            }
        }

        [TestMethod()]
        public void AddNewScoreTest()
        {
            try
            {
                // fail if a player object is not passed in
                ScoreboardDB.AddNewScore(null);
                Assert.Fail();
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            // add some players and check if their name is correct
            Player player1 = new Player();
            player1.Name = "karen";
            player1.Score = 3;
            ScoreboardDB.AddNewScore(player1);
            Assert.AreEqual(player1.Name, ScoreboardDB.GetAllScores().Last().Name);
            Assert.AreNotEqual("frank", ScoreboardDB.GetAllScores().Last().Name);

            Player player2 = new Player();
            player2.Name = "shannon";
            player2.Score = 6;
            ScoreboardDB.AddNewScore(player2);
            Assert.AreEqual(player2.Name, ScoreboardDB.GetAllScores().Last().Name);
            Assert.AreNotEqual("tim", ScoreboardDB.GetAllScores().Last().Name);

            Player player3 = new Player();
            player3.Name = "john";
            player3.Score = 8;
            ScoreboardDB.AddNewScore(player3);
            Assert.AreEqual(player3.Name, ScoreboardDB.GetAllScores().Last().Name);
            Assert.AreNotEqual("joe", ScoreboardDB.GetAllScores().Last().Name);
        }

        [TestMethod()]
        public void UpdateScoreTest()
        {
            try
            {
                // fail if a player object is not passed in
                ScoreboardDB.UpdateScore(null);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            // add a player...
            Player player1 = new Player();
            player1.Name = "brian";
            player1.Score = 10;
            ScoreboardDB.AddNewScore(player1);

            // last item should be brian with score 10 because it was just added
            Assert.AreEqual(player1.Name, ScoreboardDB.GetAllScores().Last().Name);
            Assert.AreEqual(player1.Score, ScoreboardDB.GetAllScores().Last().Score);

            // updating player score should increment score by 1
            int oldScore = player1.Score; // keep track of old score
            ScoreboardDB.UpdateScore(player1);
            Assert.AreEqual(player1.Name, ScoreboardDB.GetAllScores().Last().Name);
            int newScore = player1.Score + 1;
            Assert.AreEqual(newScore, ScoreboardDB.GetAllScores().Last().Score);
            Assert.AreNotEqual(oldScore, ScoreboardDB.GetAllScores().Last().Score);
            Assert.IsTrue(ScoreboardDB.GetAllScores().Last().Score == oldScore + 1);
        }
    }
}