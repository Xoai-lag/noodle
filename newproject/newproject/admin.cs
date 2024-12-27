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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtFood.Text;
            decimal price = Convert.ToDecimal(txtGia.Text);
            var temp = products.ReadProductsFormFile("Products.txt");
            int quantity = (int)nudQuantity.Value;
            int len = temp.Count;
            string id = "FD" + len.ToString();
            var result = new products(id, name, price, quantity);
            temp.Add(result);
            bool err = products.WriteProductsToFile("Products.txt", temp);
            if (err) 
            {
                dgvFood.DataSource = null;
                dgvFood.DataSource = temp;
            }

        }

        private void admin_Load(object sender, EventArgs e)
        {
            var temp = products.ReadProductsFormFile("Products.txt");
            dgvFood.DataSource = temp;
        }
    }
}
