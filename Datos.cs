using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Proyecto_ropa
{
    internal class Datos
    {
        public static int id_u { get; set; }

        public static void dato1(int id)
        {
            Datos.id_u = id;
        }

        public static List<Prenda> prendas = new List<Prenda>();

        public static void AgregarPrenda(string nombre, string cantidad, string precio, string genero, Image imagen, string id)
        {
            var prenda = new Prenda { Nombre = nombre, Cantidad = cantidad, Precio = precio, Genero = genero, Imagen = imagen, Id = id };

            prendas.Add(prenda);
        }

      
   

        public class Prenda
        {
            public string Nombre { get; set; }
            public string Cantidad { get; set; }
            public string Precio { get; set; }
            public string Genero { get; set; }
            public Image Imagen { get; set; }

            public string Id { get; set; }
        }

        public static double total {  get; set; }
        public static double cambio { get; set; }

        public static double efectivo { get; set; }
        public static double iva {  get; set; }
        public static double subtotal { get; set; }

        public static void dato3(double total, double cambio, double efectivo, double subtotal)
        {
            Datos.total = total;
            Datos.cambio = cambio;
            Datos.efectivo = efectivo;
            Datos.subtotal = subtotal;
            
        }

        public static void dato4(double iva)
        {
            Datos.iva = iva;
        }

        public static int cantidad { get; set; }

        public static void dato5(int cantidad)
        {
            Datos.cantidad = cantidad;
        }


    }
}
