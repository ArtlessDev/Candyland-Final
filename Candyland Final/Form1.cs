﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            SquareType square = new SquareType();

            


            label1.Text = card.PickCard(square);


















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

        }
    }
}
