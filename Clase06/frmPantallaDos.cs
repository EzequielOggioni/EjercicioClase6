using System;
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
    public partial class FrmPantallaDos : Form
    {
        public FrmPantallaDos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chkContraseña.ThreeState = false;
            MessageBox.Show(this.chkContraseña.CheckState.ToString());
            MessageBox.Show(this.chkContraseña.Checked.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            chkContraseña.Checked = rdoMasculino.Checked;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string palabra="";
            foreach( object item in  this.lstPaises.SelectedItems)
            {
                palabra += item.ToString();
            }

            MessageBox.Show(palabra);
        }

        private void FrmPantallaDos_Load(object sender, EventArgs e)
        {
            

            cmbCaracteristicas.Items.Clear();
            cmbCaracteristicas.Items.Add("+1");
            cmbCaracteristicas.Items.Add("+2");
            cmbCaracteristicas.Items.Add("+3");
            cmbCaracteristicas.Items.Add("+4");
            cmbCaracteristicas.Items.Add("+5");

            

        }
    }
}
