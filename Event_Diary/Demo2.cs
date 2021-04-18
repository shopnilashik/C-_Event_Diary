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

namespace Event_Diary
{

    public partial class Demo2 : Form
    {
       SqlConnection con = new SqlConnection(@"Data Source=SHOPNIL\SQLEXPRESS01;Initial Catalog=user_DB;Integrated Security=True");
        public Demo2()
        {
            InitializeComponent();
        }
        public void dis_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tb_demo";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

            private void Demo2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_DBDataSet1.tb_demo' table. You can move, or remove it, as needed.
            this.tb_demoTableAdapter.Fill(this.user_DBDataSet1.tb_demo);
            dis_data();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tb_demo values('" + EventNo.Text + "','" + EventName.Text + "','" + EventDate.Text + "','" + comboBox1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            MessageBox.Show("Record Insert...");
            
            EventNo.Text = "";
            EventName.Text = "";
            EventDate.Text = "";
            comboBox1.Text = "";
            





        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tb_demo where id = '" + EventNo.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            MessageBox.Show("Record Deleted...");
            
            EventNo.Text = "";
            EventName.Text = "";
            EventDate.Text = "";
            comboBox1.Text = "";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update tb_demo set eventName ='"+ EventDate + "' where eventName = '" + EventName.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            MessageBox.Show("Record Deleted...");

            EventNo.Text = "";
            EventName.Text = "";
            EventDate.Text = "";
            comboBox1.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
