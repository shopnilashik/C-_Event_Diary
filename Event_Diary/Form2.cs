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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SHOPNIL\SQLEXPRESS01;Initial Catalog=user_DB;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table_1 values('" + EventNo.Text + "','"+ EventName.Text + "','"+ EventDate.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            dis_data();
            MessageBox.Show("Record Insert...");

        }
        public void dis_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from table_1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dis_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            demo dm = new demo();
            dm.Show();
            this.Hide();
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }
    }
}
