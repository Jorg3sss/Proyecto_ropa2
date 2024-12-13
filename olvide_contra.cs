using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ropa
{
    internal class olvide_contra(Form1 form1, Cambio_contra form2)
    {
        private Form form1 = form1;
        private Form form2 = form2;

        string connection = ("Server=LAPTOP-0045SGMV\\SQLEXPRESS;Database=proyecto_ropa;Integrated Security=True;TrustServerCertificate=True;");
        public void restaurar(string usuario, string contraseña)
        {
            string query = "SELECT * FROM usuarios WHERE Nombre_user = @user;";

            using (SqlConnection cone = new SqlConnection(connection))
            {
                cone.Open();

                using (SqlCommand cmd = new SqlCommand(query, cone))
                {

                    cmd.Parameters.AddWithValue("@user", usuario);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {

                        query = "UPDATE usuarios SET Contraseña = @nuevaContraseña WHERE Nombre_user = @user;";


                        cmd.CommandText = query;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@nuevaContraseña", contraseña);
                        cmd.Parameters.AddWithValue("@user", usuario);



                        int filasActualizadas = cmd.ExecuteNonQuery();

                        if (filasActualizadas > 0)
                        {
                            MessageBox.Show("Contraseña actualizada con éxito");
                          

                            form1.Show();
                            form2.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la contraseña");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                }
            }
        }
    }
}
