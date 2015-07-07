using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Controls
{
    public partial class rdXml : Form
    {
        public rdXml()
        {
            InitializeComponent();
        }

        private XmlDocument xDoc;
        private string Path;
        private void button1_Click(object sender, EventArgs e)
        {
            var of= new OpenFileDialog();
            of.Filter = @"xml document|*.xml";
            if (of.ShowDialog() == DialogResult.OK)
            {
                 xDoc = new XmlDocument();
                Path = of.FileName;
                 xDoc.Load(Path);
                 textBox1.Text= xDoc.SelectSingleNode("People/person/name").InnerText;
                 textBox2.Text= xDoc.SelectSingleNode("People/person/age").InnerText;
                 textBox3.Text= xDoc.SelectSingleNode("People/person/email").InnerText;
                //foreach (XmlNode node in xDoc.SelectNodes("People/person"))
                //{
                //   MessageBox.Show(node.SelectSingleNode("name").InnerText);
                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xDoc.SelectSingleNode("People/person/name").InnerText = textBox1.Text;
            xDoc.SelectSingleNode("People/person/age").InnerText = textBox2.Text;
            xDoc.SelectSingleNode("People/person/email").InnerText = textBox3.Text;
            xDoc.Save(Path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog= new SaveFileDialog();
            saveFileDialog.Filter = "xml document|*.xml";
            saveFileDialog.DefaultExt = ".xml";
            saveFileDialog.FileName = "file1.xml";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlWriter xmlWriter = new XmlTextWriter(saveFileDialog.FileName,Encoding.UTF8);
                xmlWriter.WriteStartElement("People");
                xmlWriter.WriteStartElement("person");
                xmlWriter.WriteStartElement("name");
                xmlWriter.WriteString(textBox1.Text);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("age");
                xmlWriter.WriteString(textBox2.Text);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("email");
                xmlWriter.WriteString(textBox3.Text);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
                xmlWriter.Close();
               
            
                toolStripStatusLabel1.Text = @"file saving success";
            }
        }
    }
}
