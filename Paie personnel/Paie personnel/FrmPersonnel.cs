﻿using Paie_personnel.Common.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paie_personnel
{
    public partial class FrmPersonnel : Form
    {
        public FrmPersonnel()
        {
            InitializeComponent();
        }

        private void ListePersonnel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            new FrmAjouterPersonnel().ShowDialog();
        }
    }
}
