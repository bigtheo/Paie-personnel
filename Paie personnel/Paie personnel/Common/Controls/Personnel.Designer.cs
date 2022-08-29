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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom, postnom et prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fonction";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.button5.Location = new System.Drawing.Point(497, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 38);
            this.button5.TabIndex = 7;
            this.button5.Text = "Voir plus";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(53, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 2);
            this.panel1.TabIndex = 8;
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbxPhoto);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Personnel";
            this.Size = new System.Drawing.Size(664, 90);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxPhoto;
        private ElipsisControl elipsisControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}
