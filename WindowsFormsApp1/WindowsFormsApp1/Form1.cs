﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + "\n";
            if (radioButton1.Checked) s += "пол М\n";
            if (radioButton2.Checked) s += "пол Ж\n";
            s += comboBox1.SelectedItem.ToString();
            s += "\n";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                s += checkedListBox1.CheckedItems[i].ToString() + "\n";
            richTextBox1.Text = s;
        }
    }
}
