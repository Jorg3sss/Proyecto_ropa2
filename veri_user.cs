using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Proyecto_ropa
{
    internal class veri_user(Form1 form1, Form2 form2)
    {
        private Form form1 = form1;
        private Form form2 = form2;

        string connection = ("Server=LAPTOP-0045SGMV\\SQLEXPRESS;Database=proyecto_ropa;Integrated Security=True;TrustServerCertificate=True;");

        public void verificar(string usuario, string contra)
        {
            try
            {
                using (SqlConnection cone = new SqlConnection(connection))
                {
                    cone.Open();
                    string query = "SELECT Id FROM usuarios WHERE Nombre_user = @n_usuario AND Contraseña = @contraseña;";
                    using (SqlCommand cmd = new SqlCommand(query, cone))
                    {

                        cmd.Parameters.AddWithValue("@n_usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", contra);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int idUsuario = Convert.ToInt32(result);

                            Datos.dato1(idUsuario);

                            MessageBox.Show("Bienvenido(a) " + usuario);
                            Datos.prendas.Clear();

                            form2.Show();
                            form1.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o contraseña incorrectos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
