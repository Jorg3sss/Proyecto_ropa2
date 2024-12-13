using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proyecto_ropa
{
    public partial class Pantalla_final : Form
    {
        public Pantalla_final()
        {
            InitializeComponent();
            CargarCarrito();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarCarrito()
        {

            flowLayoutPanel1.Controls.Clear();

            foreach (var prenda in Datos.prendas)
            {

                Panel panelPrenda = new Panel();
                panelPrenda.Size = new Size(1300, 100);
                panelPrenda.Margin = new Padding(10);


                TableLayoutPanel tableLayout = new TableLayoutPanel();
                tableLayout.ColumnCount = 3;
                tableLayout.RowCount = 1;
                tableLayout.Dock = DockStyle.Fill;


                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));



                PictureBox pictureBox = new PictureBox
                {
                    Image = new Bitmap(prenda.Imagen, new Size(400, 400)),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill
                };






                Label nuevoLabel = new Label
                {
                    Text = $"{prenda.Nombre}   Precio: {prenda.Precio}   Género: {prenda.Genero}",
                    Font = new Font("Bahnschrift Light", 10, FontStyle.Regular),
                    ForeColor = Color.Black,

                    AutoSize = true
                };


                Label nlabel2 = new Label
                {
                    Text = $"{prenda.Cantidad}",
                    Font = new Font("Bahnschrift Light", 10, FontStyle.Regular),
                    ForeColor = Color.Black,

                    AutoSize = true
                };


                tableLayout.Controls.Add(pictureBox, 0, 0);
                tableLayout.Controls.Add(nuevoLabel, 1, 0);
                tableLayout.Controls.Add(nlabel2, 2, 0);



                panelPrenda.Controls.Add(tableLayout);


                flowLayoutPanel1.Controls.Add(panelPrenda);
            }
        }

        private void Pantalla_final_Load(object sender, EventArgs e)
        {
            label4.Text = Datos.subtotal.ToString();
            label5.Text = Datos.iva.ToString();
            label6.Text = Datos.total.ToString();

            label7.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            label9.Text = DateTime.Now.ToString("hh:mm tt");


        }

        int n;
        public void num(int n)
        {
            this.n = n;
            label8.Text = $"Número de compra: {n.ToString()}";
        }

        private void nota()
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Datos.prendas.Clear();

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
