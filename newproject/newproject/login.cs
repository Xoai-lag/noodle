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
<<<<<<< HEAD
            string name = txtName.Text;
            string pass = txtPass.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass)) {
=======
            string name=txtName.Text;
            string pass=txtPass.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass) ){
>>>>>>> master
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
<<<<<<< HEAD
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                    this.Show();
=======
                    
>>>>>>> master
                }
            }
            MessageBox.Show("Khong ton tai tai khoan!");
        }
    }
}
