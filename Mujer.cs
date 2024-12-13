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
    public partial class Mujer : Form
    {
        public Mujer()
        {
            InitializeComponent();
        }

        private void blusa1_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            blusa1.Tag = new { Nombre = "Blusa rosada", Precio = "350", id = "6", Genero = "Mujer", Descripcion = "Blusa rosada sin mangas, ideal para días cálidos, confeccionada \nen tela ligera y suave, perfecta \npara un estilo casual." };


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

        private void Mujer_Load(object sender, EventArgs e)
        {

        }

        private void blusa2_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            blusa2.Tag = new { Nombre = "Blusa amarilla", Precio = "500", id = "7", Genero = "Mujer", Descripcion = "Blusa de manga larga amarilla, confeccionada en suave seda,\n ideal para el frío. Elegante y cálida, \nperfecta para invierno." };


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

        private void falda_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            falda.Tag = new { Nombre = "Falda de cuadros rojos y negros", Precio = "200", id = "8", Genero = "Mujer", Descripcion = "Blusa rosada sin mangas, ideal para días cálidos, confeccionada \nen tela ligera y suave, perfecta \npara un estilo casual." };


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

        private void blusa3_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            blusa3.Tag = new { Nombre = "Blusa tipo polo rosada", Precio = "499", id = "9", Genero = "Mujer", Descripcion = "Blusa tipo polo rosada, cómoda y versátil. \nCon un corte ajustado, perfecta para un look casual \ny fresco en cualquier ocasión." };


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

        private void blusa4_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            blusa4.Tag = new { Nombre = "Top manga larga rosado", Precio = "150", id = "10", Genero = "Mujer", Descripcion = "Top de manga larga rosado, ajustado y elegante, \nconfeccionado en tela suave y cómoda, \nideal para climas frescos y ocasiones casuales." };


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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hombre hombre = new Hombre();
            hombre.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();
            carrito.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
