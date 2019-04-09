﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06
{
    public partial class FrmPrincipal : Form
    {

        int paint=0;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //this.Close();

            //this.btnSalir.Text = "No se como se hace";

            //MessageBox.Show("Hola mundo");
            
            FrmPantallaDos frmPantallaDos = new FrmPantallaDos();
            frmPantallaDos.button1.Text = "llegué";
            //frmPantallaDos.MdiParent = this;
            if (frmPantallaDos.ShowDialog() == DialogResult.OK)
              MessageBox.Show(this.IsMdiContainer.ToString());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load");
        }

        

        private void FrmPrincipal_Activated(object sender, EventArgs e)
        {
            paint++;
            this.Text = " activate nº " + paint;
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
