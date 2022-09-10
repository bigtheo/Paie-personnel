namespace Paie_personnel
{
    partial class Personnel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personnel));
            this.PbxPhoto = new System.Windows.Forms.PictureBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_fonction = new System.Windows.Forms.Label();
            this.BtnVoirPlus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.elipsisControl1 = new Paie_personnel.ElipsisControl();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxPhoto
            // 
            this.PbxPhoto.BackColor = System.Drawing.Color.White;
            this.PbxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("PbxPhoto.Image")));
            this.PbxPhoto.Location = new System.Drawing.Point(25, 14);
            this.PbxPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbxPhoto.Name = "PbxPhoto";
            this.PbxPhoto.Size = new System.Drawing.Size(69, 70);
            this.PbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPhoto.TabIndex = 0;
            this.PbxPhoto.TabStop = false;
            this.PbxPhoto.MouseLeave += new System.EventHandler(this.Personnel_MouseLeave);
            this.PbxPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Personnel_MouseMove);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(115, 16);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(240, 28);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "Nom, postnom et prénom";
            this.lbl_nom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Personnel_MouseMove);
            // 
            // lbl_fonction
            // 
            this.lbl_fonction.AutoSize = true;
            this.lbl_fonction.Location = new System.Drawing.Point(116, 47);
            this.lbl_fonction.Name = "lbl_fonction";
            this.lbl_fonction.Size = new System.Drawing.Size(81, 25);
            this.lbl_fonction.TabIndex = 2;
            this.lbl_fonction.Text = "Fonction";
            this.lbl_fonction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Personnel_MouseMove);
            // 
            // BtnVoirPlus
            // 
            this.BtnVoirPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVoirPlus.FlatAppearance.BorderSize = 0;
            this.BtnVoirPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoirPlus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoirPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.BtnVoirPlus.Location = new System.Drawing.Point(421, 34);
            this.BtnVoirPlus.Name = "BtnVoirPlus";
            this.BtnVoirPlus.Size = new System.Drawing.Size(121, 38);
            this.BtnVoirPlus.TabIndex = 7;
            this.BtnVoirPlus.Text = "Voir plus";
            this.BtnVoirPlus.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(53, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 2);
            this.panel1.TabIndex = 8;
            this.panel1.MouseLeave += new System.EventHandler(this.Personnel_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Personnel_MouseMove);
            // 
            // elipsisControl1
            // 
            this.elipsisControl1.ControlTarget = this.PbxPhoto;
            this.elipsisControl1.CornerRadius = 60;
            // 
            // Personnel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnVoirPlus);
            this.Controls.Add(this.lbl_fonction);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.PbxPhoto);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Personnel";
            this.Size = new System.Drawing.Size(570, 90);
            this.MouseLeave += new System.EventHandler(this.Personnel_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Personnel_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxPhoto;
        private ElipsisControl elipsisControl1;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_fonction;
        private System.Windows.Forms.Button BtnVoirPlus;
        private System.Windows.Forms.Panel panel1;
    }
}
