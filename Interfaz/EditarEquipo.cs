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
    public partial class ModificarEquipo : Form
    {
        public ModificarEquipo()
        {
            InitializeComponent();
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {

            VerificacionEditar verificar = new VerificacionEditar();
            verificar.ShowDialog();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
