﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuestas
{
    public partial class FuncAdministrador : Form
    {
        public FuncAdministrador()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetearEncuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estás seguro de que quieres eliminar todos los regristros?");
        }

        //Los menús strip que hacen la ventana modal. 
    }
}
