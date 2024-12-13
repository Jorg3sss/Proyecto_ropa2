using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ropa
{
    public partial class new_user : Form
    {
        public new_user()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Apellidos.Text) || string.IsNullOrEmpty(Tel.Text) || string.IsNullOrEmpty(Correo.Text) || string.IsNullOrEmpty(Usuario.Text) || string.IsNullOrEmpty(Contra1.Text) || string.IsNullOrEmpty(Contra2.Text))
            {
                MessageBox.Show("Ingresa todos los datos");
            }

            else
            {
                if (Contra1.Text.Equals(Contra2.Text))
                {
                    if(Tel.TextLength < 10 ||  Tel.TextLength > 10)
                    {
                        MessageBox.Show("Ingresa 10 digitos en el télefono");
                    }

                    else
                    {
                        Form1 form1 = new Form1();
                        Nuevo_user nuevo_user = new Nuevo_user(form1, this);
                        nuevo_user.crear_user(Nombre.Text, Usuario.Text, Contra1.Text, Apellidos.Text, Correo.Text, Tel.Text);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                
            }
        }
    }
}
