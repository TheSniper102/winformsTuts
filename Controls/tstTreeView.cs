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
    public partial class tstTreeView : Form
    {
        public tstTreeView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("People");
            treeView1.Nodes[0].Nodes.Add("ahmed(kind of people)");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("mohamed(ahmed son)");
            treeView1.Nodes.Add("Animal");
            treeView1.Nodes[1].Nodes.Add("Lion");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("shibl");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(treeView1.Nodes.Count >0)
            //treeView1.SelectedNode.Remove();
                RemoveChecked(treeView1.Nodes);
        }
        List<TreeNode> tnList= new List<TreeNode>(); 
        void RemoveChecked(TreeNodeCollection tnCollection)
        {

            if (tnCollection.Count > 0)
            {
                foreach (TreeNode tc in tnCollection)
                {
                    if (tc != null)
                    {
                        if (tc.Checked)
                            tnList.Add(tc);
                        else if (tc.Nodes.Count != 0)
                            RemoveChecked(tc.Nodes);

                        foreach (TreeNode tn in tnList)
                        {
                            treeView1.Nodes.Remove(tn);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode tn= new TreeNode();
            tn.Text = "people";
            tn.ImageIndex = 2;
            treeView1.Nodes.Add(tn);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
