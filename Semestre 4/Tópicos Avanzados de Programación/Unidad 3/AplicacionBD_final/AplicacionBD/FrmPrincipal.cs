﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionBD
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MsConexionBD_Click(object sender, EventArgs e)
        {
            FrmConexionBD FrmConexionBD = new FrmConexionBD();
            FrmConexionBD.Show();
        }
    }
}
