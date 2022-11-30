using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Candyland_Final
{
    public static class ScoreboardDB
    {
        static OleDbConnection dbConnection;
        static OleDbDataAdapter dataAdapter;
        static DataSet scoreboardDataSet;
        static string sqlCommand;
        static DataTable scoreboardTable;

        public static List<Player> GetAllScores()
        {
            List<Player> scoreList = new List<Player>();
            
            try
            {
                dbConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=CandyLandStats.accdb;");
                sqlCommand = "select * from Scoreboard";
                dataAdapter = new OleDbDataAdapter(sqlCommand, dbConnection);
                scoreboardDataSet = new DataSet("Scoreboard");
                dataAdapter.Fill(scoreboardDataSet, "Scoreboard");
                scoreboardTable = scoreboardDataSet.Tables["Scoreboard"];

                foreach (DataRow record in scoreboardTable.Rows)
                {
                    Player p = new Player();
                    p.Name = record["PlayerName"].ToString();
                    p.Score = int.Parse(record["Score"].ToString());
                    scoreList.Add(p);
                }
                Console.WriteLine("db read successfully");
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            } finally
            {
                dbConnection.Close();
            }
            return scoreList;
        }
        public static void AddNewScore(Player p)
        {
            string connectionStr = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=CandyLandStats.accdb;";
            string sqlCommand = $"insert into Scoreboard (PlayerName, Score) values ('{p.Name}', '{p.Score}')";

            dbConnection = new OleDbConnection(connectionStr);
            OleDbCommand insertCommand = new OleDbCommand(sqlCommand, dbConnection);
            try
            {
                dbConnection.Open();
                int status = insertCommand.ExecuteNonQuery();
                if (status > 0)
                {
                    Console.WriteLine("insert successful");
                }
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex);
            }
            catch (SystemException ex)
            {
                Console.WriteLine("system error");
            }
            finally
            {
                dbConnection.Close();
            }
        }
        public static void UpdateScore(Player player)
        {
            string connectionStr = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=CandyLandStats.accdb;";

            string sqlCommand = $"update Scoreboard set Score = '{player.Score + 1}' where PlayerName = '{player.Name}'";
            dbConnection = new OleDbConnection(connectionStr);
            OleDbCommand updateCommand = new OleDbCommand(sqlCommand, dbConnection);
            try
            {
                dbConnection.Open();
                int status = updateCommand.ExecuteNonQuery();
                if (status > 0)
                {
                    Console.WriteLine("update successful");
                }
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex);
            }
            catch (SystemException ex)
            {
                Console.WriteLine("system error");
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
