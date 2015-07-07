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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //progressBar1.Value += 10;

            //style must be not marquee to work
           //progressBar1.PerformStep();

            //style must be marquee to work
            progressBar1.MarqueeAnimationSpeed = 20;
        }
    }
}
