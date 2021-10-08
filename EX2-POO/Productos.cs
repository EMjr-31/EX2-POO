using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_POO
{
    class Productos
    {
        int codigo;
        string nombre;
        double precio;
        int cantida;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantida { get => cantida; set => cantida = value; }
    }
}
