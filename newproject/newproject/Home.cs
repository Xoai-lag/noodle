using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newproject
{
    public partial class Home : Form
    {
        private static List<products> result = new List<products>();
        string path = "Products.txt";
        public Home()
        {
            InitializeComponent();
        }
        public static List<products> GetFood()
        {
            List<products> temp = new List<products>();
            temp=result;
            return temp;
        }
        public static void ResetFood()
        {
            List<products> temp = new List<products>();
            result = temp;
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
                comboBox1.Items.Add($"{product.product_name}");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill bill= new Bill();
            bill.ShowDialog();
            this.Show();
            Home home= new Home();
            home.Show();
            this.Hide();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            string productName = selectedItem.Trim();
            var listproduct = products.ReadProductsFormFile(path);
            var sl = (int)nudHome.Value;
            if (sl < 1) { MessageBox.Show("Vui lòng chọn số lượng!"); return; }
            foreach (var product in listproduct)
            {
                if (productName == product.product_name)
                {
                    // Tạo đối tượng món ăn và thêm vào danh sách
                    var temp = new products(product.product_id, product.product_name, product.price, sl);
                    result.Add(temp);
                    dgvHome.DataSource = null;
                    dgvHome.DataSource = result;
                }
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvHome.CurrentRow != null)
            {
                // Lấy chỉ số của dòng đang được chọn
                int rowIndex = dgvHome.CurrentRow.Index;

                if (rowIndex >= 0 && rowIndex < result.Count)
                {
                    // Cập nhật thông tin sản phẩm tại chỉ số dòng
                    result[rowIndex].product_name = comboBox1.SelectedItem.ToString();
                    result[rowIndex].quantity = (int)nudHome.Value;
                    if(result[rowIndex].quantity < 1) { MessageBox.Show("Vui lòng chọn số lượng!"); return; }
                    // Cập nhật lại `DataGridView`
                    dgvHome.DataSource = null;
                    dgvHome.DataSource = result;
                    MessageBox.Show("Sua Thanh Cong!");
                }
            }
        }

        private void dgvHome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedIndex = dgvHome.Rows[e.RowIndex];
                // Lấy tên sản phẩm từ cột 1
                string productName = selectedIndex.Cells[1].Value.ToString();

                // Tìm vị trí trong ComboBox và cập nhật
                int comboIndex = comboBox1.FindStringExact(productName);
                if (comboIndex >= 0)
                {
                    comboBox1.SelectedIndex = comboIndex;
                }

                // Lấy số lượng từ cột 3 và cập nhật
                int quantity = Convert.ToInt32(selectedIndex.Cells[3].Value);
                nudHome.Value = quantity;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn trong DataGridView không
            if (dgvHome.CurrentRow != null)
            {
                // Lấy chỉ số của hàng đang được chọn
                int rowIndex = dgvHome.CurrentRow.Index;

                if (rowIndex >= 0 && rowIndex < result.Count)
                {
                    // Xóa sản phẩm khỏi danh sách `result`
                    result.RemoveAt(rowIndex);

                    // Cập nhật lại DataGridView
                    dgvHome.DataSource = null;
                    dgvHome.DataSource = result;

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
