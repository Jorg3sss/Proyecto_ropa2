using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static Proyecto_ropa.Datos;

namespace Proyecto_ropa
{
    public partial class pago : Form
    {
        public pago()
        {
            InitializeComponent();
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

        private void pago_Load(object sender, EventArgs e)
        {
            CargarCarrito();
            total();
        }

        double tot = 0;
        double iva = 0;
        double subtotal = 0;
        public void total()
        {
            foreach (var prenda in Datos.prendas)
            {
                iva = (iva + (int.Parse(prenda.Cantidad) * int.Parse(prenda.Precio))) * 0.16;

                subtotal = (subtotal + (int.Parse(prenda.Cantidad) * int.Parse(prenda.Precio)));


            }

            tot = (subtotal + iva);
            Datos.dato4(iva);

            label1.Text = "El total es: MXN " + tot.ToString("F2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        string connection = ("Server=LAPTOP-0045SGMV\\SQLEXPRESS;Database=proyecto_ropa;Integrated Security=True;TrustServerCertificate=True;");
        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(Efectivo.Text))
            {
                MessageBox.Show("Ingresa un valor");

            }

            else
            {
                double n = int.Parse(Efectivo.Text);

                if (n >= tot)
                {
                    double cambio = n - tot;
                    MessageBox.Show($"El cambio es: {cambio.ToString("F2")}");
                    Datos.dato3(tot, (n - tot), double.Parse(Efectivo.Text), subtotal);
                    int idCompra;

                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();


                        string queryCompra = @"INSERT INTO compra (id_user, total_prendas, subtotal, iva, total, efectivo, cambio) 
                           VALUES (@id_us, @prendas, @subtotal, @iva, @total, @efectivo, @cambio);
                           SELECT SCOPE_IDENTITY();";


                        using (SqlCommand cmdCompra = new SqlCommand(queryCompra, conn))
                        {
                            cmdCompra.Parameters.AddWithValue("@id_us", Datos.id_u);
                            cmdCompra.Parameters.AddWithValue("@prendas", Datos.cantidad);
                            cmdCompra.Parameters.AddWithValue("@subtotal", Datos.subtotal);
                            cmdCompra.Parameters.AddWithValue("@iva", Datos.iva);
                            cmdCompra.Parameters.AddWithValue("@total", Datos.total);
                            cmdCompra.Parameters.AddWithValue("@efectivo", double.Parse(Efectivo.Text));
                            cmdCompra.Parameters.AddWithValue("@cambio", cambio);


                            idCompra = Convert.ToInt32(cmdCompra.ExecuteScalar());

                        }
                        string queryDetalle = @"INSERT INTO detalle_compra (id_compra, id_prenda, cantidad) 
                                VALUES (@id_com, @id_prenda, @cantidad)";

                        foreach (var prenda in Datos.prendas)
                        {
                            using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conn))
                            {
                                cmdDetalle.Parameters.AddWithValue("@id_com", idCompra);
                                cmdDetalle.Parameters.AddWithValue("@id_prenda", prenda.Id);
                                cmdDetalle.Parameters.AddWithValue("@cantidad", prenda.Cantidad);

                                cmdDetalle.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Pago realizado con éxito");


                    Pantalla_final pantalla_Final = new Pantalla_final();
                    pantalla_Final.num(idCompra);
                    pantalla_Final.Show();

                    this.Hide();
                }



                else
                {
                    MessageBox.Show("Ingresa un valor mayor al total");
                }
            }


        }

        private void Efectivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();
            carrito.Show();
            this.Hide();
        }
    }
}
