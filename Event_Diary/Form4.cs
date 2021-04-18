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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SHOPNIL\SQLEXPRESS01;Initial Catalog=user_DB;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void dis_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from table_fn";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_DBDataSet3.table_fn' table. You can move, or remove it, as needed.
            this.table_fnTableAdapter1.Fill(this.user_DBDataSet3.table_fn);
            // TODO: This line of code loads data into the 'user_DBDataSet2.table_fn' table. You can move, or remove it, as needed.
            this.table_fnTableAdapter.Fill(this.user_DBDataSet2.table_fn);
            // TODO: This line of code loads data into the 'user_DBDataSet.tb_event' table. You can move, or remove it, as needed.
            this.tb_eventTableAdapter.Fill(this.user_DBDataSet.tb_event);
            dis_data();

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
        public void Insert(string fileName, byte[] image)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["UploadImageToDatabase.Propertise.Settings.DatabaseconnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using (SqlCommand cmd = new SqlCommand("insert into table_fn(filename,photo) value(@filename,photo)"))
                {
                    cmd.CommandType = CommandType.Text;
                    

                
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table_fn values('" + EventNo.Text + "','" + EventName.Text + "','" + EventDate.Text + "','"+ comboBox1.Text+ "','" + textBox1.Text + "','" + storyBox.Text + "')";
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            Demo2 f = new Demo2();
            f.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from table_fn where id = '" + EventNo.Text + "'";
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
            cmd.CommandText = "update table_fn set eventName ='" + EventDate + "' where eventName = '" + EventName.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            MessageBox.Show("Record Updated...");

            EventNo.Text = "";
            EventName.Text = "";
            EventDate.Text = "";
            comboBox1.Text = "";
        }
    }
}
