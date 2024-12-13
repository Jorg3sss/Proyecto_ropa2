namespace Proyecto_ropa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuario.Text) || string.IsNullOrWhiteSpace(contra.Text))
            {
                MessageBox.Show("Ingresa todos los datos solicitados");
            }
            else
            {
                Form2 form2 = new Form2();
                veri_user veri = new veri_user(this, form2);
                veri.verificar(usuario.Text, contra.Text);


            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cambio_contra cambio_Contra = new Cambio_contra();
            cambio_Contra.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new_user new_us = new new_user();
            new_us.Show();
            this.Hide();
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
