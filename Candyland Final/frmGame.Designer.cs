
namespace Candyland_Final
{
    partial class frmGame
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbBoardImage = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.pbPlayer3 = new System.Windows.Forms.PictureBox();
            this.pbPlayer4 = new System.Windows.Forms.PictureBox();
            this.pbCurrentCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentCard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(315, 537);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(2);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(74, 19);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw a card";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Location = new System.Drawing.Point(56, 122);
            this.pbPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(15, 16);
            this.pbPlayer1.TabIndex = 2;
            this.pbPlayer1.TabStop = false;
            // 
            // pbBoardImage
            // 
            this.pbBoardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBoardImage.InitialImage = null;
            this.pbBoardImage.Location = new System.Drawing.Point(0, 0);
            this.pbBoardImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbBoardImage.Name = "pbBoardImage";
            this.pbBoardImage.Size = new System.Drawing.Size(504, 420);
            this.pbBoardImage.TabIndex = 3;
            this.pbBoardImage.TabStop = false;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.Location = new System.Drawing.Point(74, 122);
            this.pbPlayer2.Margin = new System.Windows.Forms.Padding(2);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(15, 16);
            this.pbPlayer2.TabIndex = 4;
            this.pbPlayer2.TabStop = false;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(397, 537);
            this.btnEndTurn.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(74, 19);
            this.btnEndTurn.TabIndex = 5;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Visible = false;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTurn.Location = new System.Drawing.Point(24, 422);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(134, 25);
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
            // pbCurrentCard
            // 
            this.pbCurrentCard.Location = new System.Drawing.Point(29, 459);
            this.pbCurrentCard.Name = "pbCurrentCard";
            this.pbCurrentCard.Size = new System.Drawing.Size(67, 97);
            this.pbCurrentCard.TabIndex = 10;
            this.pbCurrentCard.TabStop = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 587);
            this.Controls.Add(this.pbCurrentCard);
            this.Controls.Add(this.pbPlayer4);
            this.Controls.Add(this.pbPlayer3);
            this.Controls.Add(this.lblCurrentTurn);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pbBoardImage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGame";
            this.Text = "Candyland";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox pbBoardImage;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.PictureBox pbPlayer3;
        private System.Windows.Forms.PictureBox pbPlayer4;
        private System.Windows.Forms.PictureBox pbCurrentCard;
    }
}

