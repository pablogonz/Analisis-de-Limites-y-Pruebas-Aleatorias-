using System;

namespace katainfo
{
    public class information
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }
        public information(string nombre, string apellido, int edad)
        {

            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
        public static void Main()
        {

        }
    }
}
