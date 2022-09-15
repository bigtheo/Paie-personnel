namespace Paie_personnel
{
    partial class FrmAjouterAvance
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
            this.label12 = new System.Windows.Forms.Label();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.panelBarreTitre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.frmFermer = new System.Windows.Forms.Button();
            this.txt_matricule = new Windows.Forms.HintTextBox(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_mois = new System.Windows.Forms.ComboBox();
            this.nup_montant = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_retenu = new System.Windows.Forms.Label();
            this.lbl_fonction = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_salaire_de_brut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elipsisControl1 = new Paie_personnel.ElipsisControl();
            this.elipsisControl2 = new Paie_personnel.ElipsisControl();
            this.panelBarreTitre.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_montant)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(134, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Matricule :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.BtnEnregistrer.Enabled = false;
            this.BtnEnregistrer.FlatAppearance.BorderSize = 0;
            this.BtnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.BtnEnregistrer.Location = new System.Drawing.Point(170, 323);
            this.BtnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(171, 39);
            this.BtnEnregistrer.TabIndex = 1;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = false;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // panelBarreTitre
            // 
            this.panelBarreTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(244)))));
            this.panelBarreTitre.Controls.Add(this.label1);
            this.panelBarreTitre.Controls.Add(this.frmFermer);
            this.panelBarreTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarreTitre.Location = new System.Drawing.Point(0, 0);
            this.panelBarreTitre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBarreTitre.Name = "panelBarreTitre";
            this.panelBarreTitre.Size = new System.Drawing.Size(529, 56);
            this.panelBarreTitre.TabIndex = 6;
            this.panelBarreTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarreTitre_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajout d\'une nouvelle avance";
            // 
            // frmFermer
            // 
            this.frmFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frmFermer.FlatAppearance.BorderSize = 0;
            this.frmFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmFermer.ForeColor = System.Drawing.Color.White;
            this.frmFermer.Location = new System.Drawing.Point(466, 13);
            this.frmFermer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frmFermer.Name = "frmFermer";
            this.frmFermer.Size = new System.Drawing.Size(39, 33);
            this.frmFermer.TabIndex = 0;
            this.frmFermer.Text = "X";
            this.frmFermer.UseVisualStyleBackColor = true;
            this.frmFermer.Click += new System.EventHandler(this.FrmFermer_Click);
            // 
            // txt_matricule
            // 
            this.txt_matricule.EnterToTab = false;
            this.txt_matricule.ForeColor = System.Drawing.Color.Gray;
            this.txt_matricule.HintColor = System.Drawing.Color.Gray;
            this.txt_matricule.HintValue = "Matricule du personnel";
            this.txt_matricule.IsNumerical = true;
            this.txt_matricule.Location = new System.Drawing.Point(244, 41);
            this.txt_matricule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(171, 30);
            this.txt_matricule.TabIndex = 3;
            this.txt_matricule.TextForeColor = System.Drawing.Color.Black;
            this.txt_matricule.Value = "";
            this.txt_matricule.TextChanged += new System.EventHandler(this.txt_matricule_TextChanged);
            this.txt_matricule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_matricule_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nup_montant);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbl_retenu);
            this.panel1.Controls.Add(this.lbl_fonction);
            this.panel1.Controls.Add(this.lbl_nom);
            this.panel1.Controls.Add(this.lbl_salaire_de_brut);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnEnregistrer);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbx_mois);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_matricule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 403);
            this.panel1.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mois :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cbx_mois
            // 
            this.cbx_mois.FormattingEnabled = true;
            this.cbx_mois.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.cbx_mois.Location = new System.Drawing.Point(244, 80);
            this.cbx_mois.Name = "cbx_mois";
            this.cbx_mois.Size = new System.Drawing.Size(171, 31);
            this.cbx_mois.TabIndex = 21;
            this.cbx_mois.SelectedIndexChanged += new System.EventHandler(this.cbx_mois_SelectedIndexChanged);
            // 
            // nup_montant
            // 
            this.nup_montant.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_montant.Location = new System.Drawing.Point(244, 260);
            this.nup_montant.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nup_montant.Name = "nup_montant";
            this.nup_montant.Size = new System.Drawing.Size(171, 30);
            this.nup_montant.TabIndex = 34;
            this.nup_montant.ThousandsSeparator = true;
            this.nup_montant.ValueChanged += new System.EventHandler(this.nup_montant_ValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "Montant :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbl_retenu
            // 
            this.lbl_retenu.AutoSize = true;
            this.lbl_retenu.Location = new System.Drawing.Point(244, 229);
            this.lbl_retenu.Name = "lbl_retenu";
            this.lbl_retenu.Size = new System.Drawing.Size(101, 23);
            this.lbl_retenu.TabIndex = 32;
            this.lbl_retenu.Text = "Total retenu";
            this.lbl_retenu.Click += new System.EventHandler(this.lbl_retenu_Click);
            // 
            // lbl_fonction
            // 
            this.lbl_fonction.AutoSize = true;
            this.lbl_fonction.Location = new System.Drawing.Point(244, 160);
            this.lbl_fonction.Name = "lbl_fonction";
            this.lbl_fonction.Size = new System.Drawing.Size(76, 23);
            this.lbl_fonction.TabIndex = 31;
            this.lbl_fonction.Text = "Fonction";
            this.lbl_fonction.Click += new System.EventHandler(this.lbl_fonction_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(244, 124);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(60, 23);
            this.lbl_nom.TabIndex = 30;
            this.lbl_nom.Text = "Noms ";
            this.lbl_nom.Click += new System.EventHandler(this.lbl_nom_Click);
            // 
            // lbl_salaire_de_brut
            // 
            this.lbl_salaire_de_brut.AutoSize = true;
            this.lbl_salaire_de_brut.Location = new System.Drawing.Point(244, 193);
            this.lbl_salaire_de_brut.Name = "lbl_salaire_de_brut";
            this.lbl_salaire_de_brut.Size = new System.Drawing.Size(124, 23);
            this.lbl_salaire_de_brut.TabIndex = 29;
            this.lbl_salaire_de_brut.Text = "Salaire de base";
            this.lbl_salaire_de_brut.Click += new System.EventHandler(this.lbl_salaire_de_brut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Noms :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Salaire brut :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fonction :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total retenu :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // elipsisControl1
            // 
            this.elipsisControl1.ControlTarget = this;
            this.elipsisControl1.CornerRadius = 15;
            // 
            // elipsisControl2
            // 
            this.elipsisControl2.ControlTarget = this.BtnEnregistrer;
            this.elipsisControl2.CornerRadius = 15;
            // 
            // FrmAjouterAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 466);
            this.Controls.Add(this.panelBarreTitre);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAjouterAvance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAjouterAvance";
            this.panelBarreTitre.ResumeLayout(false);
            this.panelBarreTitre.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_montant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnEnregistrer;
        private System.Windows.Forms.Panel panelBarreTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frmFermer;
        private Windows.Forms.HintTextBox txt_matricule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbx_mois;
        private ElipsisControl elipsisControl1;
        private ElipsisControl elipsisControl2;
        private System.Windows.Forms.NumericUpDown nup_montant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_retenu;
        private System.Windows.Forms.Label lbl_fonction;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_salaire_de_brut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}