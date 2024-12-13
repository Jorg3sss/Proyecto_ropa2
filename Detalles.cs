using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_ropa
{
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }

        int n = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                n = 0;
            }
            else
            {
                var prendaA = Datos.prendas.FirstOrDefault(para => para.Nombre == prendaSeleccionada);

                if (prendaA != null)
                {
                    n = int.Parse(prendaA.Cantidad);
                    n = n - 1;
                    prendaA.Cantidad = n.ToString();
                    label4.Text = n.ToString();
                }
                else
                {
                    n = n - 1;
                    label4.Text = n.ToString();
                }
                
            }
        }

        string prendaSeleccionada, precio, genero;
        string id_prenda;
        Image image;
        public void prenda(string prenda, Image imagen, string descripción, string precio, string genero, string id_prenda)
        {

            prendaSeleccionada = prenda;
            this.precio = precio;
            this.genero = genero;
            this.id_prenda = id_prenda;
            image = imagen;

            label1.Text = prendaSeleccionada;
            pictureBox1.Image = imagen;
            label3.Text = descripción;
            Precio.Text = "MXN " + precio;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            var prendaA = Datos.prendas.FirstOrDefault(para => para.Nombre == prendaSeleccionada);

            if (prendaA != null)
            {
                MessageBox.Show("Ya tienes un producto de estos en tu carrito");
                label4.Text = prendaA.Cantidad.ToString();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var prendaA = Datos.prendas.FirstOrDefault(para => para.Nombre == prendaSeleccionada);

            if (prendaA != null)
            {
                n = int.Parse(prendaA.Cantidad);
                n = n + 1;
                prendaA.Cantidad = n.ToString();
                label4.Text = n.ToString();
            }
            else
            {
                n = n + 1;
                label4.Text = n.ToString();
            }
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label4.Text == "0")
            {
                MessageBox.Show("Selecciona una cantidad");
            }
            else
            {
                
                var prendaA = Datos.prendas.FirstOrDefault(para => para.Nombre == prendaSeleccionada);
                if (prendaA != null)
                {
                    prendaA.Cantidad = label4.Text;
                    MessageBox.Show("Prenda actualizada");
                    if (genero == "Mujer")
                    {
                        Mujer mujer = new Mujer();
                        mujer.Show();
                        this.Hide();
                    }
                    else
                    {
                        Hombre hombre = new Hombre();
                        hombre.Show();
                        this.Hide();
                    }
                }
                else
                {
                    Datos.AgregarPrenda(prendaSeleccionada, label4.Text, precio, genero, image, id_prenda);
                    MessageBox.Show("Prenda agregada al carrito");
                    if (genero == "Mujer")
                    {
                        Mujer mujer = new Mujer();
                        mujer.Show();
                        this.Hide();
                    }
                    else
                    {
                        Hombre hombre = new Hombre();
                        hombre.Show();
                        this.Hide();
                    }
                }
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (genero == "Mujer")
            {
                Mujer mujer = new Mujer();
                mujer.Show();
                this.Hide();
            }
            else
            {
                Hombre hombre = new Hombre();
                hombre.Show();
                this.Hide();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
