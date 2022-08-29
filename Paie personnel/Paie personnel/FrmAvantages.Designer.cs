namespace Paie_personnel
{
    partial class FrmAvantages
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
            this.ListePersonnel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnImprimer = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListePersonnel
            // 
            this.ListePersonnel.AutoScroll = true;
            this.ListePersonnel.AutoSize = true;
            this.ListePersonnel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ListePersonnel.BackColor = System.Drawing.Color.White;
            this.ListePersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListePersonnel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ListePersonnel.Location = new System.Drawing.Point(0, 0);
            this.ListePersonnel.Name = "ListePersonnel";
            this.ListePersonnel.Size = new System.Drawing.Size(728, 370);
            this.ListePersonnel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 431);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ListePersonnel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(728, 370);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnImprimer);
            this.panel3.Controls.Add(this.BtnAjouter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 61);
            this.panel3.TabIndex = 4;
            // 
            // BtnImprimer
            // 
            this.BtnImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.BtnImprimer.FlatAppearance.BorderSize = 0;
            this.BtnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimer.ForeColor = System.Drawing.Color.White;
            this.BtnImprimer.Location = new System.Drawing.Point(194, 14);
            this.BtnImprimer.Name = "BtnImprimer";
            this.BtnImprimer.Size = new System.Drawing.Size(94, 32);
            this.BtnImprimer.TabIndex = 1;
            this.BtnImprimer.Text = "Imprimer";
            this.BtnImprimer.UseVisualStyleBackColor = false;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.BtnAjouter.FlatAppearance.BorderSize = 0;
            this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouter.ForeColor = System.Drawing.Color.White;
            this.BtnAjouter.Location = new System.Drawing.Point(69, 14);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(94, 32);
            this.BtnAjouter.TabIndex = 0;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 51);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les avantages";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(728, 482);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmAvantages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAvantages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAvantages";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ListePersonnel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnImprimer;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}