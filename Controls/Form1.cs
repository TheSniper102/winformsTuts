using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
           
            textBox1.Text = Clipboard.GetText();
        
            
            timer1.Start();

            var fd= new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            { 
                pictureBox1.ImageLocation = fd.FileName;
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2 f1 = new frm2();

            //prevent user from click first form
            //f1.ShowDialog();
            //allow user to select first from 
            f1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show("changed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView lsView= new listView();
            lsView.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tstTreeView tv= new tstTreeView();
            tv.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rdXml rdXml= new rdXml();
            rdXml.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hashing ha = new Hashing();
            ha.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "A")
            {
                button6.PerformClick();
            }
        }
    }
}
