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
    class Usuarios
    {
        /// User and pass arrays 
        public static string[] users = new string[3];
        public static string[] pass = new string[3];

        ///Encryption funtion 
        public static string Encrypt(string Source)
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
