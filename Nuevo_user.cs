using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Proyecto_ropa
{
    internal class Nuevo_user(Form1 form1, new_user form2)
    {
        
        string connection = ("Server=LAPTOP-0045SGMV\\SQLEXPRESS;Database=proyecto_ropa;Integrated Security=True;TrustServerCertificate=True;");
        public void crear_user(string nombre, string usuario, string contra, string apellidos, string correo, string tel)
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

                        MessageBox.Show("Ya existe este nombre de usuario");
                    }
                    else
                    {

                        query = "INSERT INTO usuarios (Nombre, Apellidos, Nombre_user, Correo, Tel, Contraseña) VALUES (@nombre, @apellidos, @user, @correo, @tel, @contra);";


                        cmd.CommandText = query;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellidos", apellidos);
                        cmd.Parameters.AddWithValue("@user", usuario);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@tel", tel);
                        cmd.Parameters.AddWithValue("@contra", contra);



                        int filasActualizadas = cmd.ExecuteNonQuery();

                        if (filasActualizadas > 0)
                        {
                            MessageBox.Show("Usuario creado con éxito");


                            form1.Show();
                            form2.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error al crear usuario");
                        }

                    }
                }
            }
        }
    }
}
