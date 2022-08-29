namespace Paie_personnel.Common.UserControl
{
    partial class FrmAjouterPersonnel
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
            this.elipsisControl1 = new Paie_personnel.ElipsisControl();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.panelBarreTitre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.frmFermer = new System.Windows.Forms.Button();
            this.elipsisControl2 = new Paie_personnel.ElipsisControl();
            this.hintTextBox1 = new Windows.Forms.HintTextBox(this.components);
            this.panelNom = new System.Windows.Forms.Panel();
            this.elipsisControl3 = new Paie_personnel.ElipsisControl();
            this.panelSalaire = new System.Windows.Forms.Panel();
            this.hintTextBox2 = new Windows.Forms.HintTextBox(this.components);
            this.panelEnfant = new System.Windows.Forms.Panel();
            this.hintTextBox3 = new Windows.Forms.HintTextBox(this.components);
            this.panelCNSS = new System.Windows.Forms.Panel();
            this.hintTextBox4 = new Windows.Forms.HintTextBox(this.components);
            this.elipsisControl4 = new Paie_personnel.ElipsisControl();
            this.panelPonctualite = new System.Windows.Forms.Panel();
            this.hintTextBox5 = new Windows.Forms.HintTextBox(this.components);
            this.elipsisControl5 = new Paie_personnel.ElipsisControl();
            this.elipsisControl6 = new Paie_personnel.ElipsisControl();
            this.elipsisControl7 = new Paie_personnel.ElipsisControl();
            this.panelBarreTitre.SuspendLayout();
            this.panelNom.SuspendLayout();
            this.panelSalaire.SuspendLayout();
            this.panelEnfant.SuspendLayout();
            this.panelCNSS.SuspendLayout();
            this.panelPonctualite.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsisControl1
            // 
            this.elipsisControl1.ControlTarget = this.BtnEnregistrer;
            this.elipsisControl1.CornerRadius = 6;
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.BtnEnregistrer.FlatAppearance.BorderSize = 0;
            this.BtnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.BtnEnregistrer.Location = new System.Drawing.Point(203, 519);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(94, 32);
            this.BtnEnregistrer.TabIndex = 1;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // panelBarreTitre
            // 
            this.panelBarreTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(244)))));
            this.panelBarreTitre.Controls.Add(this.label1);
            this.panelBarreTitre.Controls.Add(this.frmFermer);
            this.panelBarreTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarreTitre.Location = new System.Drawing.Point(0, 0);
            this.panelBarreTitre.Name = "panelBarreTitre";
            this.panelBarreTitre.Size = new System.Drawing.Size(521, 56);
            this.panelBarreTitre.TabIndex = 2;
            this.panelBarreTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarreTitre_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajout d\'un nouveau personel";
            // 
            // frmFermer
            // 
            this.frmFermer.FlatAppearance.BorderSize = 0;
            this.frmFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmFermer.ForeColor = System.Drawing.Color.White;
            this.frmFermer.Location = new System.Drawing.Point(474, 12);
            this.frmFermer.Name = "frmFermer";
            this.frmFermer.Size = new System.Drawing.Size(35, 23);
            this.frmFermer.TabIndex = 0;
            this.frmFermer.Text = "X";
            this.frmFermer.UseVisualStyleBackColor = true;
            this.frmFermer.Click += new System.EventHandler(this.FrmFermer_Click);
            // 
            // elipsisControl2
            // 
            this.elipsisControl2.ControlTarget = this;
            this.elipsisControl2.CornerRadius = 15;
            // 
            // hintTextBox1
            // 
            this.hintTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hintTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(168)))));
            this.hintTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hintTextBox1.EnterToTab = false;
            this.hintTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.hintTextBox1.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.hintTextBox1.HintValue = "Nom du travailleur";
            this.hintTextBox1.Location = new System.Drawing.Point(14, 11);
            this.hintTextBox1.Name = "hintTextBox1";
            this.hintTextBox1.Size = new System.Drawing.Size(398, 27);
            this.hintTextBox1.TabIndex = 50;
            this.hintTextBox1.Text = "Nom du travailleur";
            this.hintTextBox1.TextForeColor = System.Drawing.Color.White;
            this.hintTextBox1.Value = "";
            // 
            // panelNom
            // 
            this.panelNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(168)))));
            this.panelNom.Controls.Add(this.hintTextBox1);
            this.panelNom.Location = new System.Drawing.Point(53, 142);
            this.panelNom.Name = "panelNom";
            this.panelNom.Size = new System.Drawing.Size(415, 47);
            this.panelNom.TabIndex = 3;
            // 
            // elipsisControl3
            // 
            this.elipsisControl3.ControlTarget = this.panelNom;
            this.elipsisControl3.CornerRadius = 15;
            // 
            // panelSalaire
            // 
            this.panelSalaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(168)))));
            this.panelSalaire.Controls.Add(this.hintTextBox2);
            this.panelSalaire.Location = new System.Drawing.Point(53, 208);
            this.panelSalaire.Name = "panelSalaire";
            this.panelSalaire.Size = new System.Drawing.Size(415, 47);
            this.panelSalaire.TabIndex = 4;
            // 
            // hintTextBox2
            // 
            this.hintTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hintTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(168)))));
            this.hintTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hintTextBox2.EnterToTab = false;
            this.hintTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.hintTextBox2.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.hintTextBox2.HintValue = "Salaire de base";
            this.hintTextBox2.IsNumerical = true;
            this.hintTextBox2.Location = new System.Drawing.Point(14, 11);
            this.hintTextBox2.Name = "hintTextBox2";
            this.hintTextBox2.Size = new System.Drawing.Size(398, 27);
            this.hintTextBox2.TabIndex = 50;
            this.hintTextBox2.Text = "Salaire de base";
            this.hintTextBox2.TextForeColor = System.Drawing.Color.White;
            this.hintTextBox2.Value = "";
            // 
            // panelEnfant
            // 
            this.panelEnfant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(168)))));
            this.panelEnfant.Controls.Add(this.hintTextBox3);
            this.panelEnfant.Location = new System.Drawing.Point(53, 274);
            this.panelEnfant.Name = "panelEnfant";
            this.panelEnfant.Size = new System.Drawing.Size(415, 47);
            this.panelEnfant.TabIndex = 5;
            // 
            // hintTextBox3
            // 
            this.hintTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hintTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(168)))));
            this.hintTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hintTextBox3.EnterToTab = false;
            this.hintTextBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.hintTextBox3.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.hintTextBox3.HintValue = "Retenu pour enfant";
            this.hintTextBox3.Location = new System.Drawing.Point(14, 11);
            this.hintTextBox3.Name = "hintTextBox3";
            this.hintTextBox3.Size = new System.Drawing.Size(398, 27);
            this.hintTextBox3.TabIndex = 50;
            this.hintTextBox3.Text = "Retenu pour enfant";
            this.hintTextBox3.TextForeColor = System.Drawing.Color.White;
            this.hintTextBox3.Value = "";
            // 
            // panelCNSS
            // 
            this.panelCNSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(168)))));
            this.panelCNSS.Controls.Add(this.hintTextBox4);
            this.panelCNSS.Location = new System.Drawing.Point(53, 340);
            this.panelCNSS.Name = "panelCNSS";
            this.panelCNSS.Size = new System.Drawing.Size(415, 47);
            this.panelCNSS.TabIndex = 6;
            // 
            // hintTextBox4
            // 
            this.hintTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hintTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(168)))));
            this.hintTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hintTextBox4.EnterToTab = false;
            this.hintTextBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.hintTextBox4.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.hintTextBox4.HintValue = "Retenu CNSS";
            this.hintTextBox4.Location = new System.Drawing.Point(14, 11);
            this.hintTextBox4.Name = "hintTextBox4";
            this.hintTextBox4.Size = new System.Drawing.Size(398, 27);
            this.hintTextBox4.TabIndex = 50;
            this.hintTextBox4.Text = "Retenu CNSS";
            this.hintTextBox4.TextForeColor = System.Drawing.Color.White;
            this.hintTextBox4.Value = "";
            // 
            // elipsisControl4
            // 
            this.elipsisControl4.ControlTarget = this.panelSalaire;
            this.elipsisControl4.CornerRadius = 15;
            // 
            // panelPonctualite
            // 
            this.panelPonctualite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(168)))));
            this.panelPonctualite.Controls.Add(this.hintTextBox5);
            this.panelPonctualite.Location = new System.Drawing.Point(53, 406);
            this.panelPonctualite.Name = "panelPonctualite";
            this.panelPonctualite.Size = new System.Drawing.Size(415, 47);
            this.panelPonctualite.TabIndex = 7;
            // 
            // hintTextBox5
            // 
            this.hintTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hintTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(168)))));
            this.hintTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hintTextBox5.EnterToTab = false;
            this.hintTextBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.hintTextBox5.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.hintTextBox5.HintValue = "Ponctualité";
            this.hintTextBox5.Location = new System.Drawing.Point(14, 11);
            this.hintTextBox5.Name = "hintTextBox5";
            this.hintTextBox5.Size = new System.Drawing.Size(398, 27);
            this.hintTextBox5.TabIndex = 50;
            this.hintTextBox5.Text = "Ponctualité";
            this.hintTextBox5.TextForeColor = System.Drawing.Color.White;
            this.hintTextBox5.Value = "";
            // 
            // elipsisControl5
            // 
            this.elipsisControl5.ControlTarget = this.panelEnfant;
            this.elipsisControl5.CornerRadius = 15;
            // 
            // elipsisControl6
            // 
            this.elipsisControl6.ControlTarget = this.panelCNSS;
            this.elipsisControl6.CornerRadius = 15;
            // 
            // elipsisControl7
            // 
            this.elipsisControl7.ControlTarget = this.panelPonctualite;
            this.elipsisControl7.CornerRadius = 15;
            // 
            // FrmAjouterPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 612);
            this.Controls.Add(this.panelPonctualite);
            this.Controls.Add(this.panelCNSS);
            this.Controls.Add(this.panelEnfant);
            this.Controls.Add(this.panelSalaire);
            this.Controls.Add(this.panelNom);
            this.Controls.Add(this.panelBarreTitre);
            this.Controls.Add(this.BtnEnregistrer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAjouterPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout du personnel";
            this.panelBarreTitre.ResumeLayout(false);
            this.panelBarreTitre.PerformLayout();
            this.panelNom.ResumeLayout(false);
            this.panelNom.PerformLayout();
            this.panelSalaire.ResumeLayout(false);
            this.panelSalaire.PerformLayout();
            this.panelEnfant.ResumeLayout(false);
            this.panelEnfant.PerformLayout();
            this.panelCNSS.ResumeLayout(false);
            this.panelCNSS.PerformLayout();
            this.panelPonctualite.ResumeLayout(false);
            this.panelPonctualite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ElipsisControl elipsisControl1;
        private System.Windows.Forms.Button BtnEnregistrer;
        private System.Windows.Forms.Panel panelBarreTitre;
        private ElipsisControl elipsisControl2;
        private System.Windows.Forms.Button frmFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNom;
        private Windows.Forms.HintTextBox hintTextBox1;
        private ElipsisControl elipsisControl3;
        private System.Windows.Forms.Panel panelCNSS;
        private Windows.Forms.HintTextBox hintTextBox4;
        private System.Windows.Forms.Panel panelEnfant;
        private Windows.Forms.HintTextBox hintTextBox3;
        private System.Windows.Forms.Panel panelSalaire;
        private Windows.Forms.HintTextBox hintTextBox2;
        private ElipsisControl elipsisControl4;
        private System.Windows.Forms.Panel panelPonctualite;
        private Windows.Forms.HintTextBox hintTextBox5;
        private ElipsisControl elipsisControl5;
        private ElipsisControl elipsisControl6;
        private ElipsisControl elipsisControl7;
    }
}