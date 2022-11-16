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
    public partial class Form1 : Form
    {
        Player p1 = new Player(1, "jair", 0);
        Player p2 = new Player(1, "jason", 0);
        GameState gameState = new GameState();
        public Form1()
        {
            InitializeComponent();
            lblCurrentTurn.Text = "Current turn: Player " + this.gameState.CurrentTurn.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Card card = new Card();
            card.CardType = card.PickCard();

            label1.Text = card.CardType;
            

            Board board = new Board();

            if(this.gameState.CurrentTurn == 1)
            {
                p1.Position = board.GetNextSpace(ref p1, card);
                pictureBox1.Left = board.GetLeft(p1);
                pictureBox1.Top = board.GetTop(p1);
                Console.WriteLine(p1.Position + " is the player position");
            }
            else if(this.gameState.CurrentTurn == 2)
            {
                p2.Position = board.GetNextSpace(ref p2, card);
                pictureBox2.Left = board.GetLeft(p2);
                pictureBox2.Top = board.GetTop(p2);
                Console.WriteLine(p2.Position + " is the player position");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //boardImage.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Load("https://img.pokemondb.net/artwork/squirtle.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.Load("https://img.pokemondb.net/artwork/bulbasaur.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox[] players =
            {
                pictureBox1, pictureBox2
            };
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            this.gameState.RotateTurns();
            lblCurrentTurn.Text = "Current turn: Player " + this.gameState.CurrentTurn.ToString();

            //if player position is 3 and player name is cpu, then auto move the turn
        }
    }
}
