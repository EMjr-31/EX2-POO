using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace EX2_POO
{
    public partial class Form1 : Form
    {
        /// User and pass arrays 

        public Form1()
        {
            InitializeComponent();
            /// Default user
            Usuarios.users[0] = "admin";
            Usuarios.users[1] = "vendedor";
            Usuarios.users[2] = "Invitado";
            /// Default password
            Usuarios.pass[0] = Usuarios.Encrypt("admin123");
            Usuarios.pass[1] = Usuarios.Encrypt("Vendedor123");
            Usuarios.pass[2] = Usuarios.Encrypt("invitado123");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            // Users Validation
            string user =txtUser.Text.Trim();
            string pas = Usuarios.Encrypt(txtPass.Text.Trim());
            for (int i = 0; i < 3; i++)
            {
                if (user == Usuarios.users[i])
                {
                    if (pas== Usuarios.pass[i])
                    {
                        MessageBox.Show("Bienvenido "+user);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta, vulva a intentarlo");
                    }
                }
            }
           
        }
    }
}
