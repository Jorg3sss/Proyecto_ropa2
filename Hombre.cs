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
    public partial class Hombre : Form
    {
        public Hombre()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mujer mujer = new Mujer();
            mujer.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            camisa1.Tag = new { Nombre = "Camisa negra", id = "1", Precio = "300", Genero = "Hombre", Descripcion = "Camisa negra de manga corta, ideal para cualquier ocasión casual.\n Confeccionada en algodón, ligera, fresca \ny perfecta para días cálidos." };


            var data = clickedPicture.Tag as dynamic;

            string prendaSeleccionada = data.Nombre;
            string descripcion = data.Descripcion;
            string precio = data.Precio;
            string genero = data.Genero;
            string id_pren = data.id;

            Detalles detalles = new Detalles();
            detalles.prenda(prendaSeleccionada, clickedPicture.Image, descripcion, precio, genero, id_pren);
            detalles.Show();
            this.Hide();
        }

        private void camisa2_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            camisa2.Tag = new { Nombre = "Camisa blanca", Precio = "250", id = "2", Genero = "Hombre", Descripcion = "Camisa blanca de manga corta, clásica y versátil. \nIdeal para eventos formales o casuales, \nconfeccionada en algodón, fresca y elegante." };


            var data = clickedPicture.Tag as dynamic;

            string prendaSeleccionada = data.Nombre;
            string descripcion = data.Descripcion;
            string precio = data.Precio;
            string genero = data.Genero;
            string id_pren = data.id;

            Detalles detalles = new Detalles();
            detalles.prenda(prendaSeleccionada, clickedPicture.Image, descripcion, precio, genero, id_pren);
            detalles.Show();
            this.Hide();
        }

        private void camisa3_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            camisa3.Tag = new { Nombre = "Camisa naranja", Precio = "249", id = "3", Genero = "Hombre", Descripcion = "Camisa naranja de manga corta, vibrante y moderna. \nIdeal para destacar en ocasiones casuales. \nTela ligera y cómoda para el verano." };


            var data = clickedPicture.Tag as dynamic;

            string prendaSeleccionada = data.Nombre;
            string descripcion = data.Descripcion;
            string precio = data.Precio;
            string genero = data.Genero;
            string id_pren = data.id;

            Detalles detalles = new Detalles();
            detalles.prenda(prendaSeleccionada, clickedPicture.Image, descripcion, precio, genero, id_pren);
            detalles.Show();
            this.Hide();
        }

        private void hoodie_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            hoodie.Tag = new { Nombre = "Hoodie amarilla", Precio = "400", id = "4", Genero = "Hombre", Descripcion = "Hoodie amarilla, cómoda y cálida, perfecta para días frescos. \nDiseño moderno con capucha ajustable y \nbolsillo frontal estilo canguro." };

            var data = clickedPicture.Tag as dynamic;

            string prendaSeleccionada = data.Nombre;
            string descripcion = data.Descripcion;
            string precio = data.Precio;
            string genero = data.Genero;
            string id_pren = data.id;

            Detalles detalles = new Detalles();
            detalles.prenda(prendaSeleccionada, clickedPicture.Image, descripcion, precio, genero, id_pren);
            detalles.Show();
            this.Hide();
        }

        private void pantalon_Click(object sender, EventArgs e)
        {

            PictureBox clickedPicture = sender as PictureBox;

            pantalon.Tag = new { Nombre = "Pantalón gris", Precio = "650", id = "5", Genero = "Hombre", Descripcion = "Pantalón gris, versátil y elegante. \nIdeal para uso casual o formal. Confeccionado en tela cómoda, \nresistente y de ajuste perfecto." };

            var data = clickedPicture.Tag as dynamic;

            string prendaSeleccionada = data.Nombre;
            string descripcion = data.Descripcion;
            string precio = data.Precio;
            string genero = data.Genero;
            string id_pren = data.id;

            Detalles detalles = new Detalles();
            detalles.prenda(prendaSeleccionada, clickedPicture.Image, descripcion, precio, genero, id_pren);
            detalles.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();
            carrito.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hombre_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
