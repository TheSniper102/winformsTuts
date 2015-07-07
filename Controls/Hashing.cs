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
namespace Controls
{
    public partial class Hashing : Form
    {
        public Hashing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF32Encoding utf8 = new UTF32Encoding();
            string hashResult = BitConverter.ToString(md5.ComputeHash(utf8.GetBytes(textBox1.Text)));

            label1.Text = hashResult;
            label2.Text = hashResult.Length.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            UTF32Encoding utf8 = new UTF32Encoding();
            string hashResult = BitConverter.ToString(sha1.ComputeHash(utf8.GetBytes(textBox2.Text)));

            label4.Text = hashResult;
            label3.Text = hashResult.Length.ToString();
        }

        private byte[] encoded;
        private void button3_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider();
            tripleDes.Key = md5.ComputeHash(utf8.GetBytes(textBox4.Text));
            tripleDes.Mode = CipherMode.ECB;
            tripleDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tripleDes.CreateEncryptor();

            encoded = trans.TransformFinalBlock(utf8.GetBytes(textBox3.Text), 0, utf8.GetBytes(textBox3.Text).Length);
            string hashed = BitConverter.ToString(encoded);
            label6.Text = hashed;
            label5.Text = hashed.Length.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider();
            tripleDes.Key = md5.ComputeHash(utf8.GetBytes(textBox4.Text));
            tripleDes.Mode = CipherMode.ECB;
            tripleDes.Padding = PaddingMode.PKCS7;

            ICryptoTransform trans = tripleDes.CreateDecryptor();
            label9.Text = utf8.GetString(trans.TransformFinalBlock(encoded, 0, encoded.Length));
        }
    }
}
