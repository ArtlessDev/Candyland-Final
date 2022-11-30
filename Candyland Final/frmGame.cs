using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candyland_Final
{
    public partial class frmGame : Form
    {
        GameState gameState;
        Board board = new Board();
        public frmGame(GameState gs)
        {
            InitializeComponent();
            this.gameState = gs;

            addPlayersToUI();
            string playerName = this.gameState.Players[this.gameState.CurrentTurn - 1].Name;
            lblCurrentTurn.Text = "Current turn: " + playerName;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // toggle buttons so nobody can spam click and win
            this.btnDraw.Visible = false;
            this.btnEndTurn.Visible = true;

            Card card = new Card();
            card.CardType = card.PickCard();

            // Assets folder inside bin/Debug, throws exception otherwise
            string cardFilePath = $@"Assets\{card.CardType}.png";
            pbCurrentCard.Load(cardFilePath);
            pbCurrentCard.SizeMode = PictureBoxSizeMode.StretchImage;

            // account for each turn
            if(this.gameState.CurrentTurn == 1)
            {
                Player p1 = this.gameState.Players[0];
                p1.Position = board.GetNextSpace(ref p1, card);
                pbPlayer1.Left = board.GetLeft(p1);
                pbPlayer1.Top = board.GetTop(p1);
                Console.WriteLine(p1.Position + " is the player position");
            }
            else if(this.gameState.CurrentTurn == 2)
            {
                Player p2 = this.gameState.Players[1];
                p2.Position = board.GetNextSpace(ref p2, card);
                pbPlayer2.Left = board.GetLeft(p2);
                pbPlayer2.Top = board.GetTop(p2);
                Console.WriteLine(p2.Position + " is the player position");

            } else if (this.gameState.CurrentTurn == 3)
            {
                Player p3 = this.gameState.Players[2];
                p3.Position = board.GetNextSpace(ref p3, card);
                pbPlayer3.Left = board.GetLeft(p3);
                pbPlayer3.Top = board.GetTop(p3);
                Console.WriteLine(p3.Position + " is the player position");
            } else
            {
                Player p4 = this.gameState.Players[3];
                p4.Position = board.GetNextSpace(ref p4, card);
                pbPlayer4.Left = board.GetLeft(p4);
                pbPlayer4.Top = board.GetTop(p4);
                Console.WriteLine(p4.Position + " is the player position");
            }

            handleWin();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            this.pbCurrentCard.Image = null;

            // toggle buttons so nobody can spam click and win
            this.btnEndTurn.Visible = false;
            this.btnDraw.Visible = true;

            int playerCount = this.gameState.Players.Length;
            this.gameState.RotateTurns(playerCount);
            string playerName = this.gameState.Players[this.gameState.CurrentTurn - 1].Name;
            lblCurrentTurn.Text = "Current turn: " + playerName;
        }

        private void addPlayersToUI()
        {
            int playerCount = this.gameState.Players.Length;

            if (playerCount == 2)
            {
                pbPlayer1.Load("https://img.pokemondb.net/artwork/bulbasaur.jpg");
                pbPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;

                pbPlayer2.Load("https://img.pokemondb.net/artwork/squirtle.jpg");
                pbPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (playerCount == 3)
            {
                pbPlayer1.Load("https://img.pokemondb.net/artwork/bulbasaur.jpg");
                pbPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;

                pbPlayer2.Load("https://img.pokemondb.net/artwork/squirtle.jpg");
                pbPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;

                pbPlayer3.Load("https://img.pokemondb.net/artwork/charmander.jpg");
                pbPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;

                pbPlayer3.Visible = true;
            }
            else
            {
                pbPlayer1.Load("https://img.pokemondb.net/artwork/bulbasaur.jpg");
                pbPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;

                pbPlayer2.Load("https://img.pokemondb.net/artwork/squirtle.jpg");
                pbPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;

                pbPlayer3.Load("https://img.pokemondb.net/artwork/charmander.jpg");
                pbPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;

                pbPlayer4.Load("https://img.pokemondb.net/artwork/muk.jpg");
                pbPlayer4.SizeMode = PictureBoxSizeMode.StretchImage;

                pbPlayer3.Visible = true;
                pbPlayer4.Visible = true;
            }
        }

        private void handleWin()
        {
            if (this.gameState.GetFarthestPlayer().Position >= 66)
            {
                Player winner = this.gameState.GetFarthestPlayer();
                winner.Score++;

                foreach (Player p in ScoreboardDB.GetAllScores())
                {
                    if (p.Name.CompareTo(winner.Name) == 0)
                    {
                        ScoreboardDB.UpdateScore(p);
                    } else
                    {
                        ScoreboardDB.AddNewScore(winner);
                    }
                }

                frmStats statsForm = new frmStats(winner.Name);
                statsForm.ShowDialog();

                // close current form and open menu form: https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
        }
    }
}
