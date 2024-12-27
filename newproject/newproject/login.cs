namespace newproject
{
    public partial class login : Form
    {
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

        }
    }
}
