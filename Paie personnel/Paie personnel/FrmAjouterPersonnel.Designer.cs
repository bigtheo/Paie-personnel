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
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.panelBarreTitre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.frmFermer = new System.Windows.Forms.Button();
            this.txt_nom = new Windows.Forms.HintTextBox(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nup_salaire_base = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nup_transport = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nup_logement = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nup_assidite = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nup_diplome = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nup_fonction = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nup_enfant = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nup_cnss = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nup_dgi = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nup_autres = new System.Windows.Forms.NumericUpDown();
            this.elipsisControl1 = new Paie_personnel.ElipsisControl();
            this.elipsisControl2 = new Paie_personnel.ElipsisControl();
            this.elipsisControl3 = new Paie_personnel.ElipsisControl();
            this.elipsisControl4 = new Paie_personnel.ElipsisControl();
            this.elipsisControl5 = new Paie_personnel.ElipsisControl();
            this.elipsisControl6 = new Paie_personnel.ElipsisControl();
            this.elipsisControl7 = new Paie_personnel.ElipsisControl();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_fonction = new System.Windows.Forms.ComboBox();
            this.panelBarreTitre.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_salaire_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_transport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_logement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_assidite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_diplome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_fonction)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_enfant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cnss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_dgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_autres)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.BtnEnregistrer.FlatAppearance.BorderSize = 0;
            this.BtnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.BtnEnregistrer.Location = new System.Drawing.Point(361, 389);
            this.BtnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(148, 35);
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
            this.panelBarreTitre.Size = new System.Drawing.Size(882, 56);
            this.panelBarreTitre.TabIndex = 2;
            this.panelBarreTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarreTitre_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajout d\'un nouveau personel";
            // 
            // frmFermer
            // 
            this.frmFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frmFermer.FlatAppearance.BorderSize = 0;
            this.frmFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmFermer.ForeColor = System.Drawing.Color.White;
            this.frmFermer.Location = new System.Drawing.Point(819, 13);
            this.frmFermer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frmFermer.Name = "frmFermer";
            this.frmFermer.Size = new System.Drawing.Size(39, 33);
            this.frmFermer.TabIndex = 0;
            this.frmFermer.Text = "X";
            this.frmFermer.UseVisualStyleBackColor = true;
            this.frmFermer.Click += new System.EventHandler(this.FrmFermer_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.EnterToTab = false;
            this.txt_nom.ForeColor = System.Drawing.Color.Gray;
            this.txt_nom.HintColor = System.Drawing.Color.Gray;
            this.txt_nom.HintValue = "Nom, postnom et prénom ";
            this.txt_nom.Location = new System.Drawing.Point(139, 27);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(290, 30);
            this.txt_nom.TabIndex = 3;
            this.txt_nom.TextForeColor = System.Drawing.Color.Black;
            this.txt_nom.Value = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbx_fonction);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnEnregistrer);
            this.panel1.Controls.Add(this.txt_nom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 450);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nup_fonction);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nup_diplome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nup_assidite);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nup_logement);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nup_transport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nup_salaire_base);
            this.groupBox1.Location = new System.Drawing.Point(45, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 266);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avantges";
            // 
            // nup_salaire_base
            // 
            this.nup_salaire_base.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_salaire_base.Location = new System.Drawing.Point(155, 33);
            this.nup_salaire_base.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nup_salaire_base.Name = "nup_salaire_base";
            this.nup_salaire_base.Size = new System.Drawing.Size(201, 30);
            this.nup_salaire_base.TabIndex = 0;
            this.nup_salaire_base.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_salaire_base.ThousandsSeparator = true;
            this.nup_salaire_base.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salaire de base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Transport";
            // 
            // nup_transport
            // 
            this.nup_transport.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_transport.Location = new System.Drawing.Point(155, 69);
            this.nup_transport.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nup_transport.Name = "nup_transport";
            this.nup_transport.Size = new System.Drawing.Size(201, 30);
            this.nup_transport.TabIndex = 2;
            this.nup_transport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_transport.ThousandsSeparator = true;
            this.nup_transport.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Logement";
            // 
            // nup_logement
            // 
            this.nup_logement.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_logement.Location = new System.Drawing.Point(155, 105);
            this.nup_logement.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nup_logement.Name = "nup_logement";
            this.nup_logement.Size = new System.Drawing.Size(201, 30);
            this.nup_logement.TabIndex = 4;
            this.nup_logement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_logement.ThousandsSeparator = true;
            this.nup_logement.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Assidité";
            // 
            // nup_assidite
            // 
            this.nup_assidite.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_assidite.Location = new System.Drawing.Point(155, 141);
            this.nup_assidite.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nup_assidite.Name = "nup_assidite";
            this.nup_assidite.Size = new System.Drawing.Size(201, 30);
            this.nup_assidite.TabIndex = 6;
            this.nup_assidite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_assidite.ThousandsSeparator = true;
            this.nup_assidite.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Diplôme ";
            // 
            // nup_diplome
            // 
            this.nup_diplome.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_diplome.Location = new System.Drawing.Point(155, 179);
            this.nup_diplome.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nup_diplome.Name = "nup_diplome";
            this.nup_diplome.Size = new System.Drawing.Size(201, 30);
            this.nup_diplome.TabIndex = 8;
            this.nup_diplome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_diplome.ThousandsSeparator = true;
            this.nup_diplome.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fonction";
            // 
            // nup_fonction
            // 
            this.nup_fonction.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_fonction.Location = new System.Drawing.Point(155, 215);
            this.nup_fonction.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nup_fonction.Name = "nup_fonction";
            this.nup_fonction.Size = new System.Drawing.Size(201, 30);
            this.nup_fonction.TabIndex = 10;
            this.nup_fonction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_fonction.ThousandsSeparator = true;
            this.nup_fonction.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nup_autres);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nup_dgi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nup_cnss);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nup_enfant);
            this.groupBox2.Location = new System.Drawing.Point(456, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 257);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Retenus à la source";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Frais scolaire";
            // 
            // nup_enfant
            // 
            this.nup_enfant.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_enfant.Location = new System.Drawing.Point(148, 59);
            this.nup_enfant.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nup_enfant.Name = "nup_enfant";
            this.nup_enfant.Size = new System.Drawing.Size(201, 30);
            this.nup_enfant.TabIndex = 2;
            this.nup_enfant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_enfant.ThousandsSeparator = true;
            this.nup_enfant.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "CNSS";
            // 
            // nup_cnss
            // 
            this.nup_cnss.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_cnss.Location = new System.Drawing.Point(148, 95);
            this.nup_cnss.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nup_cnss.Name = "nup_cnss";
            this.nup_cnss.Size = new System.Drawing.Size(201, 30);
            this.nup_cnss.TabIndex = 4;
            this.nup_cnss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_cnss.ThousandsSeparator = true;
            this.nup_cnss.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "DGI";
            // 
            // nup_dgi
            // 
            this.nup_dgi.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_dgi.Location = new System.Drawing.Point(148, 131);
            this.nup_dgi.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nup_dgi.Name = "nup_dgi";
            this.nup_dgi.Size = new System.Drawing.Size(201, 30);
            this.nup_dgi.TabIndex = 6;
            this.nup_dgi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_dgi.ThousandsSeparator = true;
            this.nup_dgi.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 23);
            this.label11.TabIndex = 9;
            this.label11.Text = "Autres";
            // 
            // nup_autres
            // 
            this.nup_autres.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_autres.Location = new System.Drawing.Point(148, 167);
            this.nup_autres.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nup_autres.Name = "nup_autres";
            this.nup_autres.Size = new System.Drawing.Size(201, 30);
            this.nup_autres.TabIndex = 8;
            this.nup_autres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_autres.ThousandsSeparator = true;
            this.nup_autres.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // elipsisControl1
            // 
            this.elipsisControl1.ControlTarget = this.BtnEnregistrer;
            this.elipsisControl1.CornerRadius = 10;
            // 
            // elipsisControl2
            // 
            this.elipsisControl2.ControlTarget = this;
            this.elipsisControl2.CornerRadius = 15;
            // 
            // elipsisControl3
            // 
            this.elipsisControl3.ControlTarget = null;
            this.elipsisControl3.CornerRadius = 15;
            // 
            // elipsisControl4
            // 
            this.elipsisControl4.ControlTarget = null;
            this.elipsisControl4.CornerRadius = 15;
            // 
            // elipsisControl5
            // 
            this.elipsisControl5.ControlTarget = null;
            this.elipsisControl5.CornerRadius = 15;
            // 
            // elipsisControl6
            // 
            this.elipsisControl6.ControlTarget = null;
            this.elipsisControl6.CornerRadius = 15;
            // 
            // elipsisControl7
            // 
            this.elipsisControl7.ControlTarget = null;
            this.elipsisControl7.CornerRadius = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Noms";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(462, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 23);
            this.label13.TabIndex = 13;
            this.label13.Text = "Fonction";
            // 
            // cbx_fonction
            // 
            this.cbx_fonction.FormattingEnabled = true;
            this.cbx_fonction.Items.AddRange(new object[] {
            "Préfet",
            "Directeur Primaire",
            "Directeur des études",
            "Directeur de Discipline",
            "Enseignant",
            "Professeur",
            "Ouvrier",
            "Autres"});
            this.cbx_fonction.Location = new System.Drawing.Point(550, 27);
            this.cbx_fonction.Name = "cbx_fonction";
            this.cbx_fonction.Size = new System.Drawing.Size(290, 31);
            this.cbx_fonction.TabIndex = 14;
            // 
            // FrmAjouterPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarreTitre);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAjouterPersonnel";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout du personnel";
            this.panelBarreTitre.ResumeLayout(false);
            this.panelBarreTitre.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_salaire_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_transport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_logement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_assidite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_diplome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_fonction)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_enfant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cnss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_dgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_autres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ElipsisControl elipsisControl1;
        private System.Windows.Forms.Button BtnEnregistrer;
        private System.Windows.Forms.Panel panelBarreTitre;
        private ElipsisControl elipsisControl2;
        private System.Windows.Forms.Button frmFermer;
        private System.Windows.Forms.Label label1;
        private ElipsisControl elipsisControl3;
        private ElipsisControl elipsisControl4;
        private ElipsisControl elipsisControl5;
        private ElipsisControl elipsisControl6;
        private ElipsisControl elipsisControl7;
        private System.Windows.Forms.Panel panel1;
        private Windows.Forms.HintTextBox txt_nom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nup_salaire_base;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nup_transport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nup_logement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nup_assidite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nup_fonction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nup_diplome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nup_enfant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nup_cnss;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nup_dgi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nup_autres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx_fonction;
        private System.Windows.Forms.Label label13;
    }
}