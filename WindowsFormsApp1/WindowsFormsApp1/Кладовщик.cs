using System;
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
    public partial class Кладовщик : Form
    {
        public Кладовщик()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Visible = true;
            this.Close();
        }
    }
}
