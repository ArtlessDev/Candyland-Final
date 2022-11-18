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
    public partial class frmMenu : Form
    {
        GameState gameState = new GameState();
        int playerCount = 2;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            addInfoToGameState();

            // close current form and open main form: https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form
            this.Hide();
            Form1 main = new Form1(this.gameState);
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void ddlPlayerCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(this.ddlPlayerCount.Text) == 2)
            {
                this.lblName1.Visible = true;
                this.txtName1.Visible = true;
                this.lblName2.Visible = true;
                this.txtName2.Visible = true;

                this.lblName3.Visible = false;
                this.txtName3.Visible = false;
                this.lblName4.Visible = false;
                this.txtName4.Visible = false;

                this.playerCount = 2;
            } else if (int.Parse(this.ddlPlayerCount.Text) == 3)
            {
                this.lblName3.Visible = true;
                this.txtName3.Visible = true;
                this.lblName4.Visible = false;
                this.txtName4.Visible = false;

                this.playerCount = 3;
            } else
            {
                this.lblName3.Visible = true;
                this.txtName3.Visible = true;
                this.lblName4.Visible = true;
                this.txtName4.Visible = true;

                this.playerCount = 4;
            }
        }

        private void addInfoToGameState()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Player p3 = new Player();
            Player p4 = new Player();
            p1.Id = 1;
            p2.Id = 2;
            p3.Id = 3;
            p4.Id = 4;
            if (this.playerCount == 2)
            {
                p1.Name = this.txtName1.Text;
                p2.Name = this.txtName2.Text;
                Player[] players = { p1, p2 };
                this.gameState.Players = players;
            } else if (this.playerCount == 3)
            {
                p1.Name = this.txtName1.Text;
                p2.Name = this.txtName2.Text;
                p3.Name = this.txtName3.Text;
                Player[] players = { p1, p2, p3 };
                this.gameState.Players = players;
            } else
            {
                p1.Name = this.txtName1.Text;
                p2.Name = this.txtName2.Text;
                p3.Name = this.txtName3.Text;
                p4.Name = this.txtName4.Text;
                Player[] players = { p1, p2, p3, p4 };
                this.gameState.Players = players;
            }
        }
    }
}
