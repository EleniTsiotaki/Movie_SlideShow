using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erg_2
{
    public partial class Form1 : Form
    {
        int i = 0;
        List<String> images = new List<string>() { };

        public string name = "photos.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //load
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button3_Click(object sender, EventArgs e) //save
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            pictureBox1.ImageLocation = "black.png";
        }

        private void button1_Click(object sender, EventArgs e) //start
        {
            var lines = File.ReadAllLines(name);
            for (var i = 0; i < lines.Length; i += 1)
            {
                {
                    var line = lines[i];
                    images.Add(lines[i]);
                }

            }
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) //pause
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            if (i == images.Count) i = 0;
            pictureBox1.ImageLocation = images[i];
            pictureBox1.Refresh();
            i++;
        }
    }
}
