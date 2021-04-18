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
using System.Configuration;
namespace Event_Diary
{
    public partial class userForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SHOPNIL\SQLEXPRESS01;Initial Catalog=user_DB;Integrated Security=True");
        public userForm()
        {
            InitializeComponent();
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_DBDataSet4.user_tb' table. You can move, or remove it, as needed.
            this.user_tbTableAdapter.Fill(this.user_DBDataSet4.user_tb);
           
        }
        public void dis_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from user_tb";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picload = dlg.FileName.ToString();
                pictureBox1.ImageLocation = picload;
                textBox1.Text = picload;
                con.Open();
                con.Close();


            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into user_tb values('" + EventNo.Text + "','" + EventName.Text + "','" + EventDate.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + storyBox.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            EventNo.Text = "";
            EventName.Text = "";
            EventDate.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            storyBox.Text = "";


            MessageBox.Show("Record Saved...");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from user_tb where id = '" + EventNo.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            EventNo.Text = "";
            EventName.Text = "";
            EventDate.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            storyBox.Text = "";
            MessageBox.Show("Record Deleted...");
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update user_tb set eventName ='" + EventDate + "' where eventName = '" + EventName.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            MessageBox.Show("Record Updated...");

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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into user_tb values('" + EventNo.Text + "','" + EventName.Text + "','" + EventDate.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + storyBox.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            EventNo.Text = "";
            EventName.Text = "";
            EventDate.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            storyBox.Text = "";


            MessageBox.Show("Record Saved...");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from user_tb where id = '" + EventNo.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            EventNo.Text = "";
            EventName.Text = "";
            EventDate.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            storyBox.Text = "";
            MessageBox.Show("Record Deleted...");
        }

        private void btnModify_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update user_tb set eventName ='" + EventDate + "' where eventName = '" + EventName.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            MessageBox.Show("Record Updated...");

            EventNo.Text = "";
            EventName.Text = "";
            EventDate.Text = "";
            comboBox1.Text = "";
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picload = dlg.FileName.ToString();
                pictureBox1.ImageLocation = picload;
                textBox1.Text = picload;
                con.Open();
                con.Close();


            }
        }
    }
}
