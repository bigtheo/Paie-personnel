﻿namespace Paie_personnel
{
    partial class FrmPaiement
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnImprimer = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ListePersonnel = new System.Windows.Forms.FlowLayoutPanel();
            this.personnel1 = new Paie_personnel.Personnel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            this.ListePersonnel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnImprimer);
            this.panel3.Controls.Add(this.BtnAjouter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 61);
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
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(746, 529);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ListePersonnel
            // 
            this.ListePersonnel.AutoScroll = true;
            this.ListePersonnel.AutoSize = true;
            this.ListePersonnel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ListePersonnel.BackColor = System.Drawing.Color.White;
            this.ListePersonnel.Controls.Add(this.personnel1);
            this.ListePersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListePersonnel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ListePersonnel.Location = new System.Drawing.Point(0, 0);
            this.ListePersonnel.Name = "ListePersonnel";
            this.ListePersonnel.Size = new System.Drawing.Size(746, 468);
            this.ListePersonnel.TabIndex = 0;
            // 
            // personnel1
            // 
            this.personnel1.AutoSize = true;
            this.personnel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.personnel1.Fonction = "Professeur";
            this.personnel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personnel1.Location = new System.Drawing.Point(4, 5);
            this.personnel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.personnel1.Name = "personnel1";
            this.personnel1.Nom = "kapapa mumba";
            this.personnel1.Size = new System.Drawing.Size(570, 90);
            this.personnel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 529);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ListePersonnel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(746, 468);
            this.panel4.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 468);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 51);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paiements";
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(746, 529);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(746, 529);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.flowLayoutPanel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(746, 468);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 468);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(746, 61);
            this.panel7.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(194, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Imprimer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(69, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button3);
            this.panel8.Controls.Add(this.button4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 468);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(746, 61);
            this.panel8.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(194, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 32);
            this.button3.TabIndex = 1;
            this.button3.Text = "Imprimer";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(69, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 32);
            this.button4.TabIndex = 0;
            this.button4.Text = "Ajouter";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(746, 478);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // FrmPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 529);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPaiement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paiement";
            this.panel3.ResumeLayout(false);
            this.ListePersonnel.ResumeLayout(false);
            this.ListePersonnel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnImprimer;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FlowLayoutPanel ListePersonnel;
        private Personnel personnel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}