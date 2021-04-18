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
    public partial class Form1 : Form
    {
        MyConnection db = new MyConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("sp_role_login",db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@uname",textBox1.Text);
                    cmd.Parameters.AddWithValue("@upass", textBox2.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[4].ToString() == "admin")
                        {
                            Form4 d = new Form4();
                            d.Show();
                            this.Hide();
                        }
                        else if (rd[4].ToString() == "user")
                            {
                            userForm d = new userForm();
                            d.Show();
                            this.Hide();
                        }
                        

                    }
                    else {
                        MessageBox.Show("Error Login");
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
