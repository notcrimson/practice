using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            //var lolol = lol.IsMatch(password) && lol1.IsMatch(password) && lol2.IsMatch(password);
            //string check = @"^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9!@#$%^]+$";
            string s = textBox2.Text;
            string password = textBox2.Text;
            if (s.Length < 6)
                MessageBox.Show("Error");

            var pattern = new Regex(@"[0-9]+");
            var pattern1 = new Regex(@"[A-Z]+");
            var pattern2 = new Regex(@"[!@#$%^.]+");

            var Pern = pattern.IsMatch(s) && pattern1.IsMatch(s) && pattern2.IsMatch(s);

            if (Pern == false)
            {
                MessageBox.Show("Пароль должен отвечать следующим требованиям:\n • Минимум 6 символов\n • Минимум 1 прописная буква\n • Минимум 1 цифра\n • Минимум один символ из набора: !@#$%^. ");
            }
            else
            {
                string connectionString = @"Data Source=star6sql;Initial Catalog=user20;User ID=user20;Password=wsruser20";
                string sql = @"INSERT INTO dbo.Пользователи VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "','Заказчик')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    int number = command.ExecuteNonQuery();
                }
            }
            this.Close();
            //string connectionString = @"Data Source=star6sql;Initial Catalog=user20;User ID=user20;Password=wsruser20";
            //string sql = @"INSERT INTO dbo.Пользователи VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "','Заказчик')";
            ////MessageBox.Show(textBox1.Text + "  " + textBox2.Text);
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(sql, connection);
            //    int number = command.ExecuteNonQuery();
            //    //MessageBox.Show("Добавлено объектов:  " + number);
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
