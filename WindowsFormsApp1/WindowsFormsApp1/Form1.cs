using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //string check = @"^(?=.*[A-Z])(?=.*[0-9])[a-zsA-Z0-9!@#$%^]+$";
            //string password = textBox2.Text;

            //var lolol = lol.IsMatch(password) && lol1.IsMatch(password) && lol2.IsMatch(password);
            
            //if (password.Length >= 6 && Regex.IsMatch(password, check, RegexOptions.IgnoreCase))
            //{
            //    Form2 f2 = new Form2();
            //    f2.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Неправильная форма записи пароля");
            //}

            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"data source=star6sql;initial catalog=user20;user id=user20;password=wsruser20;MultipleActiveResultSets=True;App=EntityFramework";
            SqlCommand scmd = new SqlCommand("SELECT * FROM Пользователи  WHERE Логин = ('" + textBox1.Text + "') AND Пароль = ('" + textBox2.Text + "')", scn);
            scn.Open();
            string value = scmd.ExecuteScalar() as string;
            scn.Close();

            SqlDataAdapter sda = new SqlDataAdapter("Select Роль from Пользователи Where Логин='" + textBox1.Text + "' and Пароль='" + textBox2.Text + "'   ", scn);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1 && textBox1.Text.Equals(value))
            {
                switch (dt.Rows[0]["Роль"] as string)
                {
                    case "Заказчик":
                        {
                            this.Hide();
                            Заказчик ss = new Заказчик();
                            ss.Show();
                            break;
                        }

                    case "Менеджер":
                        {
                            this.Hide();
                            Менеджер mf = new Менеджер();
                            mf.Show();
                            break;
                        }
                    case "Кладовщик":
                        {
                            this.Hide();
                            Кладовщик mf = new Кладовщик();
                            mf.Show();
                            break;
                        }
                    case "Директор":
                        {
                            this.Hide();
                            Директор mf = new Директор();
                            mf.Show();
                            break;
                        }

                    default:
                        {
                            MessageBox.Show("The values are not equal!");
                            break;
                        }
                }
            }

            ////if (textBox1.Text.Equals(value))
            ////{
            ////    Form2 f2 = new Form2();
            ////    f2.Show();
            ////    MessageBox.Show("The values are equal!");
            ////}
            ////else
            ////{
            ////    MessageBox.Show("The values are not equal!");
            ////}

            //scmd.Parameters.Clear();
            //scmd.Parameters.AddWithValue("@usr", textBox1.Text);
            //scmd.Parameters.AddWithValue("@pwd", textBox2.Text);
            //scn.Open();

            //string connectionString2 = @"Data Source=star6sql;Initial Catalog=user20;User ID=user20;Password=wsruser20";
            //string sql = @"SELECT * FROM Пользователи  WHERE Логин =  ('" + textBox1.Text + "') AND Пароль = ('" + textBox2.Text + "')";
            //using (SqlConnection connection = new SqlConnection(connectionString2))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(sql, connection);
            //    int number = command.ExecuteNonQuery();
            //}
            //SqlConnection con = new SqlConnection(@"Data Source=.;Integrated Security=True;AttachDbFilename=D:\myDB.mdf");

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username = '" & textBox1.Text & "' AND [Password] = '" & textBox2.Text & "' ", con);



            //con.Open();

            //SqlDataReader sdr = cmd.ExecuteReader();

            ////  If the record can be queried, it means passing verification, then open another form.  

            //if ((sdr.Read() == true))

            //{

            //    MessageBox.Show("The user is valid!");

            //    MainForm mainForm = new MainForm();

            //    mainForm.Show();

            //    this.Hide();

            //}

            //else

            //{

            //    MessageBox.Show("Invalid username or password!");

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
