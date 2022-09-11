
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
            this.txt_userid = new Windows.Forms.HintTextBox(this.components);
            this.txt_password = new Windows.Forms.HintTextBox(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.elipsisControl1 = new Paie_personnel.ElipsisControl();
            this.elipsisControl2 = new Paie_personnel.ElipsisControl();
            this.PanelBarreDeTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBarreDeTitre
            // 
            this.PanelBarreDeTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.PanelBarreDeTitre.Controls.Add(this.label1);
            this.PanelBarreDeTitre.Controls.Add(this.BtnFermer);
            this.PanelBarreDeTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarreDeTitre.Location = new System.Drawing.Point(0, 0);
            this.PanelBarreDeTitre.Name = "PanelBarreDeTitre";
            this.PanelBarreDeTitre.Size = new System.Drawing.Size(443, 46);
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
            this.label1.Size = new System.Drawing.Size(214, 23);
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
            this.BtnFermer.Location = new System.Drawing.Point(396, 0);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(47, 46);
            this.BtnFermer.TabIndex = 1;
            this.BtnFermer.Text = "X";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // txt_userid
            // 
            this.txt_userid.EnterToTab = false;
            this.txt_userid.ForeColor = System.Drawing.Color.Gray;
            this.txt_userid.HintColor = System.Drawing.Color.Gray;
            this.txt_userid.HintValue = "Nom utilisateur";
            this.txt_userid.Location = new System.Drawing.Point(165, 110);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(238, 29);
            this.txt_userid.TabIndex = 1;
            this.txt_userid.TextForeColor = System.Drawing.Color.Black;
            this.txt_userid.Value = "";
            // 
            // txt_password
            // 
            this.txt_password.EnterToTab = false;
            this.txt_password.ForeColor = System.Drawing.Color.Gray;
            this.txt_password.HintColor = System.Drawing.Color.Gray;
            this.txt_password.HintValue = "Mot de passe";
            this.txt_password.Location = new System.Drawing.Point(165, 141);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(238, 29);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextForeColor = System.Drawing.Color.Black;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Value = "";
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
            this.BtnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.BtnConnexion.FlatAppearance.BorderSize = 0;
            this.BtnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnexion.ForeColor = System.Drawing.Color.White;
            this.BtnConnexion.Location = new System.Drawing.Point(165, 185);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(107, 35);
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
            // elipsisControl1
            // 
            this.elipsisControl1.ControlTarget = this;
            this.elipsisControl1.CornerRadius = 20;
            // 
            // elipsisControl2
            // 
            this.elipsisControl2.ControlTarget = this.BtnConnexion;
            this.elipsisControl2.CornerRadius = 15;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 245);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnConnexion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userid);
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
        private Windows.Forms.HintTextBox txt_userid;
        private Windows.Forms.HintTextBox txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnConnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ElipsisControl elipsisControl1;
        private ElipsisControl elipsisControl2;
    }
}