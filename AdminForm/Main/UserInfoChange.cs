using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class UserInfoChange : Form
    {
        UserInfoVo uservo = new UserInfoVo();
        public UserInfoChange(UserInfoVo user)
        {
            InitializeComponent();
            uservo = user;
        }

        private void UserInfoChange_Load(object sender, EventArgs e)
        {
            txtID.Text = uservo.User_ID.ToString();
            txtName.Text = uservo.User_Name;
            txtGroup.Text = uservo.Default_Process_Code;
            txtLevel.Text = uservo.UserGroup_Name;
            txtphone.Text = uservo.User_Phone;
            txtEmail.Text = uservo.User_Email;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureBox pic = new PictureBox();
                pic.Image = new Bitmap(openFileDialog1.FileName);
                pic.Tag = openFileDialog1.FileName;

                FileStream fs = new FileStream(pic.Tag.ToString(), FileMode.Open, FileAccess.Read);
                byte[] bImage = new byte[fs.Length];
                fs.Read(bImage, 0, (int)fs.Length);

                fs.Close();
                //string fileName = openFileDialog1.FileName;
                //string[] fileNameArr = fileName.Split('\\');
                //for (int i = 0; i < fileNameArr.Length; i++)
                //{W
                //    fileName = fileNameArr[i];
                //}

                MES_DB.UserInfoService service = new MES_DB.UserInfoService();
                ImageConverter converter = new ImageConverter();
                byte[] imagebyte = (byte[])converter.ConvertTo(pic.Image, typeof(byte[]));
                uservo.User_Image = imagebyte;
                uservo.User_Email = txtEmail.Text;
                uservo.User_Phone = txtphone.Text;
                service.InsImage(uservo);

                if (uservo.User_Image != null)
                {
                    byte[] peopleImage = uservo.User_Image;

                    TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                    picPerson.Image = (Bitmap)tc.ConvertFrom(peopleImage);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("수정이 완료되었습니다.");
        }
    }
}
