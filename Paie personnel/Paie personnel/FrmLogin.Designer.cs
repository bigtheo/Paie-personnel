
namespace Paie_personnel
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PanelBarreDeTitre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.hintTextBox1 = new Windows.Forms.HintTextBox(this.components);
            this.hintTextBox2 = new Windows.Forms.HintTextBox(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PanelBarreDeTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBarreDeTitre
            // 
            this.PanelBarreDeTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(177)))), ((int)(((byte)(233)))));
            this.PanelBarreDeTitre.Controls.Add(this.label1);
            this.PanelBarreDeTitre.Controls.Add(this.BtnFermer);
            this.PanelBarreDeTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarreDeTitre.Location = new System.Drawing.Point(0, 0);
            this.PanelBarreDeTitre.Name = "PanelBarreDeTitre";
            this.PanelBarreDeTitre.Size = new System.Drawing.Size(441, 46);
            this.PanelBarreDeTitre.TabIndex = 0;
            this.PanelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connexion à la base";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFermer.FlatAppearance.BorderSize = 0;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFermer.ForeColor = System.Drawing.Color.White;
            this.BtnFermer.Location = new System.Drawing.Point(394, 0);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(47, 46);
            this.BtnFermer.TabIndex = 1;
            this.BtnFermer.Text = "X";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // hintTextBox1
            // 
            this.hintTextBox1.EnterToTab = false;
            this.hintTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox1.HintColor = System.Drawing.Color.Gray;
            this.hintTextBox1.HintValue = "Nom utilisateur";
            this.hintTextBox1.Location = new System.Drawing.Point(165, 110);
            this.hintTextBox1.Name = "hintTextBox1";
            this.hintTextBox1.Size = new System.Drawing.Size(238, 25);
            this.hintTextBox1.TabIndex = 1;
            this.hintTextBox1.Text = "Nom utilisateur";
            this.hintTextBox1.TextForeColor = System.Drawing.Color.Black;
            this.hintTextBox1.Value = "";
            // 
            // hintTextBox2
            // 
            this.hintTextBox2.EnterToTab = false;
            this.hintTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox2.HintColor = System.Drawing.Color.Gray;
            this.hintTextBox2.HintValue = "Mot de passe";
            this.hintTextBox2.Location = new System.Drawing.Point(165, 141);
            this.hintTextBox2.Name = "hintTextBox2";
            this.hintTextBox2.Size = new System.Drawing.Size(238, 25);
            this.hintTextBox2.TabIndex = 2;
            this.hintTextBox2.Text = "Mot de passe";
            this.hintTextBox2.TextForeColor = System.Drawing.Color.Black;
            this.hintTextBox2.UseSystemPasswordChar = true;
            this.hintTextBox2.Value = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(177)))), ((int)(((byte)(233)))));
            this.BtnConnexion.FlatAppearance.BorderSize = 0;
            this.BtnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnexion.ForeColor = System.Drawing.Color.White;
            this.BtnConnexion.Location = new System.Drawing.Point(165, 182);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(114, 30);
            this.BtnConnexion.TabIndex = 5;
            this.BtnConnexion.Text = "Connexion";
            this.BtnConnexion.UseVisualStyleBackColor = false;
            this.BtnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 258);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnConnexion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hintTextBox2);
            this.Controls.Add(this.hintTextBox1);
            this.Controls.Add(this.PanelBarreDeTitre);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.PanelBarreDeTitre.ResumeLayout(false);
            this.PanelBarreDeTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBarreDeTitre;
        private System.Windows.Forms.Button BtnFermer;
        private Windows.Forms.HintTextBox hintTextBox1;
        private Windows.Forms.HintTextBox hintTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnConnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}