﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGráfica
{
    public partial class EditarMulta : Form
    {
        public EditarMulta()
        {
            InitializeComponent();
        }

        private void btnEditarMulta_Click(object sender, EventArgs e)
        {

            VerificacionEditar verificar = new VerificacionEditar();
            verificar.ShowDialog();

        }

        private void panelTipoMulta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
