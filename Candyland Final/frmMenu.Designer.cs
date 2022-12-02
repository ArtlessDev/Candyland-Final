
namespace Candyland_Final
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.ddlPlayerCount = new System.Windows.Forms.ComboBox();
            this.lblPlayerCount = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.lblName4 = new System.Windows.Forms.Label();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.pbMM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Let\'s Play Candyland!";
            // 
            // ddlPlayerCount
            // 
            this.ddlPlayerCount.FormattingEnabled = true;
            this.ddlPlayerCount.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.ddlPlayerCount.Location = new System.Drawing.Point(59, 111);
            this.ddlPlayerCount.Name = "ddlPlayerCount";
            this.ddlPlayerCount.Size = new System.Drawing.Size(121, 21);
            this.ddlPlayerCount.TabIndex = 1;
            this.ddlPlayerCount.Text = "2";
            this.ddlPlayerCount.SelectedIndexChanged += new System.EventHandler(this.ddlPlayerCount_SelectedIndexChanged);
            // 
            // lblPlayerCount
            // 
            this.lblPlayerCount.AutoSize = true;
            this.lblPlayerCount.Location = new System.Drawing.Point(59, 92);
            this.lblPlayerCount.Name = "lblPlayerCount";
            this.lblPlayerCount.Size = new System.Drawing.Size(99, 13);
            this.lblPlayerCount.TabIndex = 2;
            this.lblPlayerCount.Text = "How many players?";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(372, 362);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(59, 170);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 20);
            this.txtName1.TabIndex = 4;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(59, 217);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(100, 20);
            this.txtName2.TabIndex = 5;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(59, 154);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(72, 13);
            this.lblName1.TabIndex = 8;
            this.lblName1.Text = "Enter Name 1";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(56, 201);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(72, 13);
            this.lblName2.TabIndex = 9;
            this.lblName2.Text = "Enter Name 2";
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.Location = new System.Drawing.Point(56, 248);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(72, 13);
            this.lblName3.TabIndex = 11;
            this.lblName3.Text = "Enter Name 3";
            this.lblName3.Visible = false;
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(59, 264);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(100, 20);
            this.txtName3.TabIndex = 10;
            this.txtName3.Visible = false;
            // 
            // lblName4
            // 
            this.lblName4.AutoSize = true;
            this.lblName4.Location = new System.Drawing.Point(56, 296);
            this.lblName4.Name = "lblName4";
            this.lblName4.Size = new System.Drawing.Size(72, 13);
            this.lblName4.TabIndex = 13;
            this.lblName4.Text = "Enter Name 4";
            this.lblName4.UseWaitCursor = true;
            this.lblName4.Visible = false;
            // 
            // txtName4
            // 
            this.txtName4.Location = new System.Drawing.Point(59, 312);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(100, 20);
            this.txtName4.TabIndex = 12;
            this.txtName4.Visible = false;
            // 
            // pbMM
            // 
            this.pbMM.InitialImage = null;
            this.pbMM.Location = new System.Drawing.Point(221, 92);
            this.pbMM.Name = "pbMM";
            this.pbMM.Size = new System.Drawing.Size(215, 221);
            this.pbMM.TabIndex = 14;
            this.pbMM.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 412);
            this.Controls.Add(this.pbMM);
            this.Controls.Add(this.lblName4);
            this.Controls.Add(this.txtName4);
            this.Controls.Add(this.lblName3);
            this.Controls.Add(this.txtName3);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblPlayerCount);
            this.Controls.Add(this.ddlPlayerCount);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Candyland Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbMM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlPlayerCount;
        private System.Windows.Forms.Label lblPlayerCount;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.Label lblName4;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.PictureBox pbMM;
    }
}