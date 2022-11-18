
namespace Candyland_Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.boardImage = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.pbPlayer3 = new System.Windows.Forms.PictureBox();
            this.pbPlayer4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 563);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 561);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw a card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Location = new System.Drawing.Point(56, 122);
            this.pbPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(15, 16);
            this.pbPlayer1.TabIndex = 2;
            this.pbPlayer1.TabStop = false;
            // 
            // boardImage
            // 
            this.boardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boardImage.Image = ((System.Drawing.Image)(resources.GetObject("boardImage.Image")));
            this.boardImage.Location = new System.Drawing.Point(0, 0);
            this.boardImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boardImage.Name = "boardImage";
            this.boardImage.Size = new System.Drawing.Size(504, 488);
            this.boardImage.TabIndex = 3;
            this.boardImage.TabStop = false;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.Location = new System.Drawing.Point(74, 122);
            this.pbPlayer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(15, 16);
            this.pbPlayer2.TabIndex = 4;
            this.pbPlayer2.TabStop = false;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(410, 561);
            this.btnEndTurn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(74, 19);
            this.btnEndTurn.TabIndex = 5;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Location = new System.Drawing.Point(9, 537);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(61, 13);
            this.lblCurrentTurn.TabIndex = 6;
            this.lblCurrentTurn.Text = "current turn";
            // 
            // pbPlayer3
            // 
            this.pbPlayer3.Location = new System.Drawing.Point(93, 122);
            this.pbPlayer3.Margin = new System.Windows.Forms.Padding(2);
            this.pbPlayer3.Name = "pbPlayer3";
            this.pbPlayer3.Size = new System.Drawing.Size(15, 16);
            this.pbPlayer3.TabIndex = 7;
            this.pbPlayer3.TabStop = false;
            this.pbPlayer3.Visible = false;
            // 
            // pbPlayer4
            // 
            this.pbPlayer4.Location = new System.Drawing.Point(112, 122);
            this.pbPlayer4.Margin = new System.Windows.Forms.Padding(2);
            this.pbPlayer4.Name = "pbPlayer4";
            this.pbPlayer4.Size = new System.Drawing.Size(15, 16);
            this.pbPlayer4.TabIndex = 8;
            this.pbPlayer4.TabStop = false;
            this.pbPlayer4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 594);
            this.Controls.Add(this.pbPlayer4);
            this.Controls.Add(this.pbPlayer3);
            this.Controls.Add(this.lblCurrentTurn);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boardImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox boardImage;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.PictureBox pbPlayer3;
        private System.Windows.Forms.PictureBox pbPlayer4;
    }
}

