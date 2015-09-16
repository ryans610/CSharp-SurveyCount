using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SurveyCount
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> result = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
            Form1_Resize(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("No input!");
                return;
            }
            listBox1.Items.Clear();
            result.Clear();
            List<string> spStr = richTextBox1.Text.Split(new char[] { '\n', ' ', ',' }).ToList<string>();
            foreach (string s in spStr.ToArray())
            {
                if (string.IsNullOrEmpty(s))
                {
                    spStr.Remove(s);
                }
            }
            foreach (string s in spStr)
            {
                if (result.Keys.Contains<string>(s))
                {
                    result[s] = result[s] + 1;
                }
                else
                {
                    result.Add(s, 1);
                }
            }
            foreach (KeyValuePair<string, int> o in result)
            {
                listBox1.Items.Add(o.Key + "," + o.Value.ToString());
            }
            richTextBox1.Clear();
        }

        private void saveFileSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No result!");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "CSV (Comma-Separated) (*.csv)|*.csv|All Files (*.*)|*.*";
            sfd.DefaultExt = "csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    foreach (KeyValuePair<string, int> o in result)
                    {
                        writer.WriteLine("\"" + o.Key + "\"," + o.Value.ToString());
                    }
                }
                MessageBox.Show("Save as " + sfd.FileName + "!");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int i = (this.Width - 40) / 2;
            richTextBox1.Width = i;
            listBox1.Height = richTextBox1.Height;
            listBox1.Width = richTextBox1.Width;
            listBox1.Location = new Point(i + 15, richTextBox1.Location.Y);
            button1.Location = new Point(button1.Location.X, richTextBox1.Location.Y + richTextBox1.Height + 10);
        }

        private void openFileOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(ofd.FileName, true))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void exitEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            listBox1.Items.Clear();
        }
    }
}
