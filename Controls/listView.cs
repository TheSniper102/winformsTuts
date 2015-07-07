using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Controls
{
    public partial class listView : Form
    {
        public listView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           ListViewItem lv= new ListViewItem(textBox1.Text);
            lv.SubItems.Add(textBox2.Text);
            lv.SubItems.Add(textBox3.Text);
            listView1.Items.Add(lv);
            textBox1.Text = textBox2.Text = textBox3.Text = null;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
              MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
               
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.BackColor = Color.Yellow;
            toolStripStatusLabel1.Text = "file opened";
           
        }

        private void listView_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000,"test list view","text goes here",ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("not allowed click", "yeas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
