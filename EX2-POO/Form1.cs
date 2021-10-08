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
        public string[] users = new string[3];
        public string[] pass = new string[3];
        public Form1()
        {
            InitializeComponent();
            /// Default user
            users[0] = "admin";
            users[1] = "vendedor";
            users[2] = "Invitado";
            /// Default password
            pass[0] = Encrypt("admin123");
            pass[1] = Encrypt("Vendedor123");
            pass[2] = Encrypt("invitado123");

           /* txtUser.Text = users[0];
            txtPass.Text = pass[0];*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            // Users Validation
            string user =txtUser.Text.Trim();
            string pas = Encrypt(txtPass.Text.Trim());
            for (int i = 0; i < 3; i++)
            {
                if (user==users[i])
                {
                    if (pas==pass[i])
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
        ///Encryption funtion 
        public static string Encrypt (string Source)
        {
            string source = Source; ///text storage variable
            SHA512 sha512Hash = SHA512.Create(); /// Sha512 funtion
            //From String to byte array
            byte[] sourceBytes = Encoding.UTF8.GetBytes(source); /// Convert string to byte array
            byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes); /// ComputeHash
            string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty); ///Convert byte array to string 
            return hash;
        }
    }
}
