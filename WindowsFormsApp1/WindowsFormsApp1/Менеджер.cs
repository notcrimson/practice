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
    public partial class Менеджер : Form
    {
        public Менеджер()
        {
            InitializeComponent();
        }

        private void Менеджер_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            //f1.Show();
            f1.Visible = true;
            this.Close();
            
        }
    }
}
