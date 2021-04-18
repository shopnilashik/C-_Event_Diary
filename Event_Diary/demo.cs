using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Diary
{
    public partial class demo : Form
    {
        string fileName;
        List<tb_photo> list;
        

        public demo()
        {
            InitializeComponent();
        }
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            
            {
                return Image.FromStream(ms);
            }
        
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                pictureBox1.Image = ConvertBinaryToImage(list[listView1.FocusedItem.Index].photo);
                label2.Text = listView1.FocusedItem.SubItems[0].Text;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    label2.Text = fileName;
                    
                    pictureBox1.Image = Image.FromFile(fileName);

                }
            
            }

        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private  void btnSave_Click(object sender, EventArgs e)
        {
            using (user_DBEntities db = new user_DBEntities())
            {
                tb_photo pic = new tb_photo() { Name = fileName, photo = ConvertImageToBinary(pictureBox1.Image) };
                db.tb_photo.Add(pic);
                try {
                    db.SaveChangesAsync();
                }
                catch (DbEntityValidationException a)
                {
                    Console.WriteLine(a);
                
                }
                
                
                MessageBox.Show("Saved item");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (user_DBEntities db = new user_DBEntities())
            {
                list = db.tb_photo.ToList();
                foreach (tb_photo pic in list)
                {
                    ListViewItem item = new ListViewItem(pic.Name);
                    listView1.Items.Add(item);
                }
            }
        }

       
    }
}
