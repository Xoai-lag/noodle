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
    public partial class Home : Form
    {
        string path = "Products.txt";
        public Home()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            List<products> temp = products.ReadProductsFormFile(path);
            foreach (var product in temp)
            {
                comboBox1.Items.Add($"{product.product_name}-{product.price} VND");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }
    }
}
