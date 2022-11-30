
namespace Candyland_Final
{
    partial class frmStats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWinner = new System.Windows.Forms.Label();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(27, 24);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(38, 13);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "winner";
            // 
            // dgvStats
            // 
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Location = new System.Drawing.Point(30, 60);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.Size = new System.Drawing.Size(240, 150);
            this.dgvStats.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(195, 397);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvStats);
            this.Controls.Add(this.lblWinner);
            this.Name = "frmStats";
            this.Text = "Stats";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.Button btnMenu;
    }
}