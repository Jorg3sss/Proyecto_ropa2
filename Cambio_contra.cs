using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ropa
{
    public partial class Cambio_contra : Form
    {
        public Cambio_contra()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuario.Text) || string.IsNullOrWhiteSpace(contra1.Text) || string.IsNullOrWhiteSpace(contra2.Text))
            {
                MessageBox.Show("Ingresa todos los datos solicitados");
            }
            else
            {
                if (contra1.Text.Equals(contra2.Text))
                {
                    Form1 form1 = new Form1();
                    olvide_contra olv_contra = new olvide_contra(form1, this);
                    olv_contra.restaurar(usuario.Text, contra1.Text);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }
    }
}
