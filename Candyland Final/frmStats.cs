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
    public partial class frmStats : Form
    {
        public frmStats(string winner)
        {
            InitializeComponent();
            this.lblWinner.Text = winner + " wins!";
            addStatsToUI();
        }
        private void addStatsToUI()
        {
            this.dgvStats.ColumnCount = 2;
            this.dgvStats.Columns[0].Name = "Player";
            this.dgvStats.Columns[1].Name = "Score";

            foreach (Player p in ScoreboardDB.GetAllScores())
            {
                this.dgvStats.Rows.Add(p.Name, p.Score);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // close current form and open menu form: https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form
            this.Close();
        }
    }
}
