namespace newproject
{

    public partial class login : Form
    {
        string path = "Users.txt";
        public login()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            register registerform = new register();
            registerform.ShowDialog();
            this.Show();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPass.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass)) {
                MessageBox.Show("Vui long dien day du thong tin!");
                return;
            }
            var temp = Users.ReadUsersFormFile(path);
            foreach (var user in temp) 
            {
                if (user.UserName == name) {
                    if (user.Password != pass)
                    {
                        MessageBox.Show("Mat khau khong chinh xac!");
                        return;
                    }
                    CurrentUser.LoggedInUser = user;
                    if (user.Role == LoaiNguoiDung.Admin)
                    {
                        this.Hide();
                        admin AD = new admin();
                        AD.ShowDialog();
                        this.Show();
                        return;
                    }
                    else
                    {
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();
                        this.Show();
                        return;
                    }
                }
            }
            MessageBox.Show("Khong ton tai tai khoan!");   
        }
    }
}
