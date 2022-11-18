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
        GameState gameState;
        public Form1(GameState gs)
        {
            InitializeComponent();
            this.gameState = gs;

            addPlayersToUI();
            lblCurrentTurn.Text = "Current turn: " + this.gameState.Players[this.gameState.CurrentTurn - 1].Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Card card = new Card();
            card.CardType = card.PickCard();

            label1.Text = card.CardType;
            

            Board board = new Board();

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
            int playerCount = this.gameState.Players.Length;
            this.gameState.RotateTurns(playerCount);
            lblCurrentTurn.Text = "Current turn: " + this.gameState.Players[this.gameState.CurrentTurn - 1].Name;
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
                MessageBox.Show(this.gameState.GetFarthestPlayer().Name + " wins!\nHit 'OK' to play again");
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
        }
    }
}
