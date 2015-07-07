using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForms.process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //var fileDialog= new OpenFileDialog();
            //fileDialog.Filter = @"exe files |*.exe";
            
            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    Process.Start(fileDialog.FileName);
            //}

           //MessageBox.Show(Process.GetCurrentProcess().ProcessName);
           

            lstBox.DataSource = Process.GetProcesses().Select(p=>p.ProcessName).ToList();
            if(!Process.GetCurrentProcess().Responding)
                Process.GetCurrentProcess().Kill();
        }
    }
}
