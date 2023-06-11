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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //註冊區塊
        public void button1_Click(object sender, EventArgs e)
        {
            String st1=textBox1.Text; 
            String st2=textBox2.Text;
            SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = user_information; Integrated Security=True; Connect Timeout=30; Encrypt=False;");//連線資料庫
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO user_data(account,password)VALUES ('"+st1+"','"+st2+"')", connection);//重要1
            SqlCommand run = new SqlCommand("SELECT * FROM user_data WHERE (account='" + st1 + "')AND (password ='" + st2 + "')", connection);//重要2
            SqlDataReader adapter = run.ExecuteReader();  
            if(adapter.HasRows==false)
            {
                MessageBox.Show("註冊完成");//hellok
                adapter.Close();
                cmd.ExecuteNonQuery();
            }
            else
            {
                adapter.Close();
                MessageBox.Show("註冊完成");
            }
            connection.Close();
        }
        //登入區塊
        public void button2_Click(object sender, EventArgs e)
        {
            String st1 = textBox1.Text;
            String st2 = textBox2.Text;
            SqlConnection connection = new SqlConnection("Data Source = localhost; Initial Catalog = user_information; Integrated Security=True; Connect Timeout=30; Encrypt=False;");//連線資料庫
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM user_data WHERE (account='"+st1+"')AND (password ='"+st2+"')", connection);//重要
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows==false)
            {
                MessageBox.Show("帳號或密碼錯誤");//注意資安問題
            }
            else
            {
                MessageBox.Show("登入成功");
                Form5 form5 = new Form5();
                this.Visible = false;
                form5.Visible = true;
            }
            connection.Close();//2023/5/15
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
