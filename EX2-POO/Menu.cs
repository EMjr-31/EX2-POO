using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2_POO
{
    public partial class Menu : Form
    {
        /// Product List
        private List<Productos> Producto = new List<Productos>();
       

        public Menu()
        {
            InitializeComponent();
            ///Product entry
            Producto[0].Codigo = 1;
            Producto[0].Nombre = "Huevos";
            Producto[0].Precio=0.10;
            Producto[0].Cantida = 30;
            ///Product entry
            Producto[1].Codigo = 2;
            Producto[1].Nombre = "pollo";
            Producto[1].Precio = 5.0;
            Producto[1].Cantida = 10;
            ///Product entry
            Producto[0].Codigo = 1;
            Producto[0].Nombre = "Huevos";
            Producto[0].Precio = 0.10;
            Producto[0].Cantida = 30;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
