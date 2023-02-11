using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string file = "jianli.rtf";
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //richTextBox1.LoadFile(file);
            OpenFileDialog f = new OpenFileDialog();
            DialogResult re = f.ShowDialog();
            if (re == DialogResult.OK)
            {
                richTextBox1.LoadFile(f.FileName);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //richTextBox1.SaveFile(file);
            SaveFileDialog f = new SaveFileDialog();
            DialogResult re = f.ShowDialog();
            if (re == DialogResult.OK)
            {
                richTextBox1.SaveFile(f.FileName);
            }

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            //背景色更改为黄色
            richTextBox1.SelectionBackColor = Color.Yellow;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            //文字颜色更改为蓝色
            //richTextBox1.SelectionColor = Color.Blue;
            ColorDialog f = new ColorDialog();
            DialogResult re = f.ShowDialog();
            if (re == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = f.Color;
            }


        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //字体更改为20号黑体
           // Font font = new Font("黑体", 20);
            //richTextBox1.SelectionFont = font;
            FontDialog f = new FontDialog();
            DialogResult re = f.ShowDialog();
            if (re == DialogResult.OK)
            {
                richTextBox1.SelectionFont = f.Font;
            }


        }
    }
}
