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
    public partial class Заказчик : Form
    {
        public Заказчик()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Visible = true;
            this.Close();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=star6sql;Initial Catalog=user20;User ID=user20;Password=wsruser20";
            //string sql = @"INSERT INTO dbo.Пользователи VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')";
            //MessageBox.Show(textBox1.Text + "  " + textBox2.Text);
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(sql, connection);
            //    int number = command.ExecuteNonQuery();
            //    MessageBox.Show("Добавлено объектов:  " + number);
            //}
        }

        private void Заказчик_Load(object sender, EventArgs e)
        {

        }
    }
}
