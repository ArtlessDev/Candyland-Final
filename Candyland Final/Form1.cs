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

            p1.Position = board.GetNextSpace(ref p1, card);
            Console.WriteLine(p1.Position + " is the player position");

            //pictureBox1.Top = Board.GetNextSpaceTop(ref p1, card);
            //pictureBox1.Left = Board.GetNextSpaceLeft(ref p1, card);















            /*
            string[] squareTypeSet = { "orange", "blue" };
                                        //, "green", "yellow", "red", "purple", 
                                        //"doubleYellow", "doubleOrange", "doubleBlue", 
                                        //"doubleGreen", "doubleRed", "doublePurple", 
                                        //"special"};
            Random rnd = new Random();
            int num = rnd.Next(squareTypeSet.Length);
            string actualSquare = squareTypeSet[num].ToString();

            switch (actualSquare)
            {
                case "orange":
                    pictureBox1.Left = 195;
                    pictureBox1.Top = 45;
                    break;
            }

            label1.Text = "The Square to move to is: " + actualSquare;

            if(pictureBox1.Location.X < 450)
            {
                //pictureBox1.Left += 20;
            }
            if(pictureBox1.Location.X >= 450)
            {
                MessageBox.Show("x is above 450: " + pictureBox1.Location.X);
            }*/

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
        }
    }
}
