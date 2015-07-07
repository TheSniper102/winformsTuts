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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private Timer t;
        private void Splash_Shown(object sender, EventArgs e)
        {
            t= new Timer();
            t.Interval=3000;
            t.Start();
            this.Opacity += 10;
            t.Tick += t_Tick;
            

        }

        void t_Tick(object sender, EventArgs e)
        {
            
            t.Stop();
            Form1 f1= new Form1();
            f1.Show();
            this.Hide();
        }

       
    }
}
