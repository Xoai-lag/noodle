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
            len++;
            string id = "FD" + (len.ToString());
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
            var result = Users.ReadUsersFormFile("Users.txt");
            dgvUser.DataSource = result;
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedrow = dgvFood.Rows[e.RowIndex];
                txtFood.Text = selectedrow.Cells["product_name"].Value.ToString();
                txtGia.Text = selectedrow.Cells["price"].Value.ToString();
                nudQuantity.Value = Convert.ToInt32(selectedrow.Cells["quantity"].Value);
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvFood.CurrentRow != null)
            {
                // Lấy chỉ số của dòng đang được chọn
                int rowIndex = dgvFood.CurrentRow.Index;

                // Đọc danh sách sản phẩm từ file
                var productsList = products.ReadProductsFormFile("Products.txt");

                if (rowIndex >= 0 && rowIndex < productsList.Count)
                {
                    // Cập nhật thông tin sản phẩm tại chỉ số dòng
                    productsList[rowIndex].product_name = txtFood.Text;
                    productsList[rowIndex].price = Convert.ToDecimal(txtGia.Text);
                    productsList[rowIndex].quantity = (int)nudQuantity.Value;

                    bool err = products.WriteProductsToFile("Products.txt", productsList);
                    if (err)
                    {
                        // Cập nhật lại `DataGridView`
                        dgvFood.DataSource = null;
                        dgvFood.DataSource = productsList;
                        MessageBox.Show("Sua Thanh Cong!");
                    }
                    else
                    {
                        MessageBox.Show("Khong The Luu Du Lieu Vao File!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvFood.CurrentRow != null)
            {
                // Lấy chỉ số của dòng đang được chọn
                int rowIndex = dgvFood.CurrentRow.Index;

                // Đọc danh sách sản phẩm từ file
                var productsList = products.ReadProductsFormFile("Products.txt");

                if (rowIndex >= 0 && rowIndex < productsList.Count)
                {
                    // Xác nhận trước khi xóa
                    var confirmResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa sản phẩm này không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Xóa sản phẩm khỏi danh sách
                        productsList.RemoveAt(rowIndex);
                        // Cập nhật lại `product_id` cho các sản phẩm còn lại
                        for (int i = 0; i < productsList.Count; i++)
                        {
                            var len = i;
                            len++;
                            productsList[i].product_id = "FD" + (len);
                        }

                        // Ghi lại danh sách vào file
                        bool err = products.WriteProductsToFile("Products.txt", productsList);

                        if (err)
                        {
                            // Cập nhật lại `DataGridView`
                            dgvFood.DataSource = null;
                            dgvFood.DataSource = productsList;
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể lưu dữ liệu vào file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow != null)
            {
                int rowindex = dgvUser.CurrentRow.Index;
                var users = Users.ReadUsersFormFile("Users.txt");
                if (rowindex >= 0 && rowindex < users.Count)
                {
                    // Xác nhận trước khi xóa
                    var confirmResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa người dùng này không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (confirmResult == DialogResult.Yes)
                    {
                        users.RemoveAt(rowindex);
                        // Ghi danh sách người dùng vào file
                        bool success = Users.WriteUsersToFile("Users.txt", users);

                        if (success)
                        {
                            // Làm mới DataGridView
                            dgvUser.DataSource = null;
                            dgvUser.DataSource = users;
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể ghi dữ liệu vào file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
