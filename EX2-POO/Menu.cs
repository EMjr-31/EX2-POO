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
        int index = -1;

        public Menu( int poin)
        {
            //Pointer 
            int pos = poin;
            InitializeComponent();
            ///Message Bienvenida
            lbUser.Text = "Bienvenido "+Usuarios.users[pos];
            ///Product entry
            Productos Product1 = new Productos();
            Product1.Codigo = 1;
            Product1.Nombre = "Huevos";
            Product1.Precio=0.10;
            Product1.Cantida = 30;
            Producto.Add(Product1);
            ///Product entry
            Productos Product2 = new Productos();
            Product2.Codigo = 2;
            Product2.Nombre = "pollo";
            Product2.Precio = 5.0;
            Product2.Cantida = 10;
            Producto.Add(Product2);
            ///Product entry
            Productos Product3 = new Productos();
            Product3.Codigo = 3;
            Product3.Nombre = "Aceite";
            Product3.Precio = 3.00;
            Product3.Cantida = 50;
            Producto.Add(Product3);
            ///Product entry
            Productos Product4 = new Productos();
            Product4.Codigo = 4;
            Product4.Nombre = "Fosforos";
            Product4.Precio = 0.50;
            Product4.Cantida = 200;
            Producto.Add(Product4);
            ///Product entry
            Productos Product5 = new Productos();
            Product5.Codigo = 5;
            Product5.Nombre = "Dulces";
            Product5.Precio = 0.80;
            Product5.Cantida = 500;
            Producto.Add(Product5);
            ///Product entry
            Productos Product6 = new Productos();
            Product6.Codigo = 6;
            Product6.Nombre = "Margarina";
            Product6.Precio = 0.30;
            Product6.Cantida = 30;
            Producto.Add(Product6);
            ///Product entry
            Productos Product7 = new Productos();
            Product7.Codigo = 7;
            Product7.Nombre = "Jabon";
            Product7.Precio = 2.25;
            Product7.Cantida = 25;
            Producto.Add(Product7);
            ///Product entry
            Productos Product8 = new Productos();
            Product8.Codigo = 8;
            Product8.Nombre = "Carne";
            Product8.Precio = 2.75;
            Product8.Cantida = 35;
            Producto.Add(Product8);
            ///Product entry
            Productos Product9 = new Productos();
            Product9.Codigo = 9;
            Product9.Nombre = "Gaseosa";
            Product9.Precio = 1.80;
            Product9.Cantida = 200;
            Producto.Add(Product9);
            ///Product entry
            Productos Product10 = new Productos();
            Product10.Codigo = 10;
            Product10.Nombre = "Desechables";
            Product10.Precio = 3.25;
            Product10.Cantida = 800;
            Producto.Add(Product10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            dgvProdcutos1.DataSource = null;
            dgvProdcutos1.DataSource = Producto;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Visible = true;
            this.Visible = false;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (rbtnNombre.Checked == true)
            {
                Busqueda();
            }
            if (rbtnTodo.Checked == true)
            {
                dgvProductos2.DataSource = null;
                dgvProductos2.DataSource = Producto;
            }
        }

        ///Methodo Search
        public void Busqueda()
        {
            dgvProductos2.DataSource = null;
            string dato = textBox1.Text;
            dgvProductos2.DataSource = Producto.FindAll(p => p.Nombre.StartsWith(dato));
        }
    }
}
