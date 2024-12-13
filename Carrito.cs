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
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }
        Label nlabel2;
        private void Carrito_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight; 
            flowLayoutPanel1.WrapContents = true; 

            CargarCarrito();
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
                tableLayout.ColumnCount = 6;
                tableLayout.RowCount = 1;
                tableLayout.Dock = DockStyle.Fill;

                
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); 
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); 
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); 
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); 
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); 

                
                PictureBox pictureBox = new PictureBox
                {
                    Image = new Bitmap(prenda.Imagen, new Size(400, 400)),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill
                };

                
                Button boton = new Button
                {
                    Text = "Eliminar",
                    Size = new Size(80, 30),
                    Dock = DockStyle.None
                };
                boton.Click += (s, e) => EliminarPrenda(prenda.Nombre);

                
                Button boton2 = new Button
                {
                    Text = "--",
                    Font = new Font("Bahnschrift Light", 13, FontStyle.Regular),
                    Size = new Size(30, 30),
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.None
                };
                boton2.Click += (d, x) => menos(prenda.Cantidad, prenda.Nombre);

                
                Button boton3 = new Button
                {
                    Text = "+",
                    Font = new Font("Bahnschrift Light", 13, FontStyle.Regular),
                    Size = new Size(30, 30),
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.None
                };
                boton3.Click += (m, a) => mas(prenda.Cantidad, prenda.Nombre);

                
                Label nuevoLabel = new Label
                {
                    Text = $"{prenda.Nombre}   Precio: {prenda.Precio}   Género: {prenda.Genero}",
                    Font = new Font("Bahnschrift Light", 10, FontStyle.Regular),
                    ForeColor = Color.Black,

                    AutoSize = true
                };

                
                nlabel2 = new Label
                {
                    Text = $"{prenda.Cantidad}",
                    Font = new Font("Bahnschrift Light", 10, FontStyle.Regular),
                    ForeColor = Color.Black,

                    AutoSize = true
                };

                
                tableLayout.Controls.Add(pictureBox, 0, 0);
                tableLayout.Controls.Add(boton, 1, 0);
                tableLayout.Controls.Add(nuevoLabel, 2, 0);
                tableLayout.Controls.Add(boton2, 3, 0);
                tableLayout.Controls.Add(nlabel2, 4, 0);
                tableLayout.Controls.Add(boton3, 5, 0);

                
                panelPrenda.Controls.Add(tableLayout);

                
                flowLayoutPanel1.Controls.Add(panelPrenda);
            }
        }


        private void EliminarPrenda(string nombrePrenda)
        {
            var prendaAEliminar = Datos.prendas.FirstOrDefault(para => para.Nombre == nombrePrenda);
            if (prendaAEliminar != null)
            {
                Datos.prendas.Remove(prendaAEliminar);
                MessageBox.Show($"Se eliminó la prenda: {nombrePrenda}");
                CargarCarrito();
            }
        }

        int n;
        private void mas(string c, string nombre)
        {
            n = int.Parse(c) + 1;
            var prendaA = Datos.prendas.FirstOrDefault(para => para.Nombre == nombre);
            if (prendaA != null)
            {
                prendaA.Cantidad = n.ToString();
                CargarCarrito();
            }

        }


        private void menos(string c, string nombre)
        {
            n = int.Parse (c);

            if (n == 1)
            {
                n = 1;

                var prendaA = Datos.prendas.FirstOrDefault(para => para.Nombre == nombre);
                if (prendaA != null)
                {
                    prendaA.Cantidad = n.ToString();
                    
                }
            }

            else
            {
                n = int.Parse(c) - 1;

                var prendaA = Datos.prendas.FirstOrDefault(para => para.Nombre == nombre);
                if (prendaA != null)
                {
                    prendaA.Cantidad = n.ToString();
                    CargarCarrito();
                }
            }

        }

        int op;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz click en la imagen a eliminar");
            op = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(prendas.Count == 0)
            {
                MessageBox.Show("Aún no has ingresado prendas");
            }
            else
            {
                pago pag = new pago();
                pag.Show();
                this.Hide();

                int t_cantidad = 0;

                foreach (var prenda in Datos.prendas)
                {
                    t_cantidad = t_cantidad + int.Parse(prenda.Cantidad);
                }

                Datos.dato5(t_cantidad);


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
