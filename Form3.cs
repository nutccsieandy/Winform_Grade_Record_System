using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Management_Information_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Visible = false;
            f.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'scoreDataSet.score_table' 資料表。您可以視需要進行移動或移除。
            //this.score_tableTableAdapter.Fill(this.scoreDataSet.score_table);
            SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = score; Integrated Security=True; Connect Timeout=30; Encrypt=False;");//連線資料庫
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM score_t", connection);
            //cmd.Connection = connection;
            SqlDataReader adapter = cmd.ExecuteReader();

            LVInit();
            GetData();
            //DataSet dataset = new DataSet();


            //dataGridView1.DataSource = adapter;
            
            cmd.Parameters.Clear();


            //label1.Text = 
            //comboBox1.Items.Add(cmd);
        }

        private void LVInit()
{
    LV.HideSelection = false;
    LV.Columns.Clear();
    LV.View = View.Details;
    LV.Columns.Add("姓名", 100);
    LV.Columns.Add("國文", 100);
    LV.Columns.Add("數學", 100);
    LV.Columns.Add("英文", 100);

            LV.GridLines = true;
            LV.Font = new Font("微軟正黑體", 12);
        LV.MultiSelect = false;
            LV.FullRowSelect = true;
            LV.HideSelection = false;
        }
        void GetData()
        {
            LV.Items.Clear();

            SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = score; Integrated Security=True; Connect Timeout=30; Encrypt=False;");//連線資料庫
            SqlCommand cmd = new SqlCommand("SELECT * FROM score_t", connection);
            connection.Open();
            //cmd.Connection = connection;
            SqlDataReader adapter = cmd.ExecuteReader();

            while (adapter.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = adapter["name"].ToString();
                item.SubItems.Add(adapter["chinese"].ToString());
                item.SubItems.Add(adapter["math"].ToString());
                item.SubItems.Add(adapter["english"].ToString());
                LV.Items.Add(item);

            }
        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV.SelectedItems.Count > 0)

            {
                //System.Windows.Forms.ListView.SelectedListViewItemCollection selected = LV.SelectedItems;
                //SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = score; Integrated Security=True; Connect Timeout=30; Encrypt=False;");
                //connection.Open();
                //SqlCommand cmd = new SqlCommand("DELETE FROM score_t WHERE name = " + e.Label, connection);
                //cmd.ExecuteNonQuery();
                //connection.Close();
                //MessageBox.Show("刪除成功");

                //this.LV.SelectedItems[0].Remove();
            }
        }

        int f = 0;
        

        

        private void button2_Click(object sender, EventArgs e)
        {
            if(LV.SelectedItems.Count > 0) 
            {
                System.Windows.Forms.ListView.SelectedListViewItemCollection selected = LV.SelectedItems;
                SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = score; Integrated Security=True; Connect Timeout=30; Encrypt=False;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM score_t WHERE chinese = " + Int32.Parse(selected[0].SubItems[1].Text), connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("刪除成功");

                this.LV.SelectedItems[0].Remove();

            }
        }
        //        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        //        {
        //            SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = score; Integrated Security=True; Connect Timeout=30; Encrypt=False;");
        //            //connection.Open();




        //            if (connection.State == ConnectionState.Closed)
        //            {
        //                connection.Open();
        //            }
        //            if (e.Label != null && e.Label != "")
        //            {
        //                string RefreshString = "update fruit set 名称='" + e.Label + "'where 编号=" + (e.Item + 1).ToString();
        //                SqlCommand s_com = new SqlCommand(RefreshString, s_con);
        //                s_com.ExecuteNonQuery();
        //                s_con.Close();
        //                MessageBox.Show("数据修改成功", "提示信息",
        //                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            }
        //        }
        //-----------------------------------
        //在ListView控件中实现修改功能
        //https://blog.51cto.com/u_15127516/3470524
    }

    
    //}
}
//private void Form4_Load(object sender, EventArgs e)
//{
//    LVInit();
//    GetData();
//    //// TODO: 這行程式碼會將資料載入 'user_informationDataSet.user_data' 資料表。您可以視需要進行移動或移除。
//    //this.user_dataTableAdapter.Fill(this.user_informationDataSet.user_data);
//    ////this.score_tableTableAdapter.Fill(this.scoreDataSet.score_table);
//    //SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = user_information; Integrated Security=True; Connect Timeout=30; Encrypt=False;");//連線資料庫
//    //SqlCommand cmd = new SqlCommand("SELECT account,password FROM user_data", connection);
//    //connection.Open();
//    ////cmd.Connection = connection;
//    //SqlDataReader adapter = cmd.ExecuteReader();
//    //dataGridView1.DataSource = adapter;
//    //while(adapter.Read())
//    //{
//    //    label1.Text = adapter["password"].ToString();
//    //    dataGridView1.DataSource = adapter;

//    //}

//}

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
//void GetData()
//{
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
//        }