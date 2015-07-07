using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread t;
        private string _names = string.Empty;
        private void btnFreez_Click(object sender, EventArgs e)
        {
           
            t= new Thread(Freez);
            object[] paramters= {"mohamed",5000};
            
            t.Start(paramters);

            while (t.IsAlive) ;//wait untill thread finish
            textBox1.Text = _names;

        }

        void Freez( object name)
        {
            var arr= name as object[] ;
            //will make application freez without threading
            for (int i=0;i<(int) arr[1];i++)
            {
                _names += arr[0].ToString() + i + "\t\n";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            t.Abort();// must close thread 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
