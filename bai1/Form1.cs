﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Thong bao" , "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btntuchien_Click(object sender, EventArgs e)
        {
            txt_hienthi.Text = "Hello world";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_hienthi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
