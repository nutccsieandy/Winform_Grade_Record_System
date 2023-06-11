using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Information_System
{

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Visible = false;
            f.Visible = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String st1 = textBox1.Text;
            String st2 = textBox2.Text;
            String st3 = textBox3.Text;
            String st4 = textBox4.Text;
            SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = score; Integrated Security=True; Connect Timeout=30; Encrypt=False;");
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO score_t(name,chinese,math,english)VALUES ('" + st1 + "','" + st2 + "','"+ st3 + "','" + st4 + "')", connection);
            //SqlCommand cmd = new SqlCommand("INSERT INTO score_table(name,chinese,math,english)VALUES ('" + st1 + "','" + st2 + "')", connection);
            SqlCommand run = new SqlCommand("SELECT * FROM score_t WHERE (name='" + st1 + "')AND (chinese ='" + st2 + "')AND (math ='" + st3 + "')AND (english ='" + st4 + "')", connection);
            SqlDataReader adapter = run.ExecuteReader();
            if (adapter.HasRows == false)
            {
                MessageBox.Show("成績輸入成功");
                adapter.Close();
                cmd.ExecuteNonQuery();
            }
            else
            {
                adapter.Close();
                MessageBox.Show("註冊完成");
            }
            connection.Close();




            //String connectionString = "Data Source=localhost;Initial Catalog=score;Integrated Security=True";
            //SqlConnection connection = new SqlConnection(@connectionString);
            //connection.Open();
            //String query = "INSERT INTO score_table (name,chinese,math,english) VALUES('" + st1 + "','" + st2 + "')";
            //SqlCommand command = new SqlCommand(query, connection);
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        ////5/15test
        //private void LVInit()
        //{
        //    LV.HideSelection = false;
        //    LV.Columns.Clear();
        //    LV.View = View.Details;
        //    LV.Columns.Add("帳號", 100);
        //    LV.Columns.Add("密碼", 100);

        //    LV.GridLines = true;
        //    LV.Font = new Font("微軟正黑體", 12);
        //    LV.MultiSelect = false;
        //    LV.FullRowSelect = true;
        //    LV.HideSelection = false;
        //}
        //void GetData() {
        //    LV.Items.Clear();

        //    SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = user_information; Integrated Security=True; Connect Timeout=30; Encrypt=False;");//連線資料庫
        //    SqlCommand cmd = new SqlCommand("SELECT account,password FROM user_data", connection);
        //    connection.Open();
        //    //cmd.Connection = connection;
        //    SqlDataReader adapter = cmd.ExecuteReader();

        //    while (adapter.Read())
        //    {
        //        ListViewItem item = new ListViewItem();
        //        item.Text = adapter["Account"].ToString();
        //        item.SubItems.Add(adapter["password"].ToString());
        //        LV.Items.Add(item);

        //    }
        //}
    }
    }
