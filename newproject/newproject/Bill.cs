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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        private void Bill_Load(object sender, EventArgs e)
        {
            var ListFood = Home.GetFood();
            dgvBill.DataSource = null;
            dgvBill.DataSource = ListFood;
            decimal total = 0;
            foreach (var food in ListFood)
            {
                total += food.price * food.quantity;
            }
            tbTotalbill.Text = total.ToString();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            string orderId = Guid.NewGuid().ToString(); // Tạo OrderID duy nhất
            string customerName;

            // Kiểm tra xem có người dùng đã đăng nhập hay không
            if (CurrentUser.LoggedInUser != null)
            {
                customerName = CurrentUser.LoggedInUser.UserName; // Lấy tên người dùng nếu đã đăng nhập
            }
            else
            {
                customerName = "Khách hàng chưa đăng nhập"; // Nếu không có người dùng, đặt tên khách hàng mặc định
            }

            DateTime orderDate = DateTime.Now;
            var items = new List<item>();
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (row.Cells["product_id"].Value != null && row.Cells["quantity"].Value != null)
                {
                    string productId = row.Cells["product_id"].Value.ToString();
                    int quantity = int.Parse(row.Cells["quantity"].Value.ToString());
                    decimal price = decimal.Parse(row.Cells["price"].Value.ToString());

                    items.Add(new item(orderId, productId, quantity, price));
                }
            }

            decimal totalPrice = 0;
            foreach (var food in items)
            {
                totalPrice += food.Price * food.Quantity;
            }

            // Tạo đối tượng đơn hàng
            Orders order = new Orders(orderId, customerName, orderDate, totalPrice, items);

            // Đọc các đơn hàng hiện có từ file
            List<Orders> existingOrders = Orders.ReadOrdersFormFile("orders.txt");
            existingOrders.Add(order);

            // Ghi lại tất cả đơn hàng vào file
            bool success = Orders.WriteOrdersToFile("orders.txt", existingOrders);

            if (success)
            {

                MessageBox.Show("Đơn hàng đã được xử lý thành công.");
                if (CurrentUser.LoggedInUser != null)
                {

                    this.Close(); // Đóng Bill Form
                }
                else
                {

                    this.Close(); // Đóng Bill Form
                    login loginForm = new login();
                    loginForm.Close(); // Đóng Login Form
                }
                Home.ResetFood();
            }
            else
            {
                MessageBox.Show("Không thể lưu đơn hàng.");
            }
        }
    }
}
