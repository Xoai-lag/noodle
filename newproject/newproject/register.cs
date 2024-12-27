using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newproject
{
    public partial class register : Form
    {
        string path = "Users.txt";
        public register()
        {
            InitializeComponent();
        }


        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dangki_Click(object sender, EventArgs e)
        {
            string name=tennguoidung.Text;
            string pass=password.Text;
            string cfmpass=cfmpassword.Text;
            List<Users> users = new List<Users>();
            users = Users.ReadUsersFormFile(path);
            foreach (Users user in users) { 
                if (user.UserName == name)
                {
                    MessageBox.Show("Tai khoan da ton tai!");
                    return;
                }
            }
            if (pass != cfmpass)
            {
                MessageBox.Show("Vui long nhap mat khau xac nhan dung voi mat khau!");
                return;
            }
            var temp = new Users(name, pass, LoaiNguoiDung.User);
            users.Add(temp);
            var err = Users.WriteUsersToFile(path, users);
            if(err)
            {
                MessageBox.Show("Đăng Kí Tài Khoản Thành Công!");
            }
            else
            {
                MessageBox.Show("Đăng kí Tài Khoản Thất Bại!");
            }
            this.Close();
        }
    }
}
