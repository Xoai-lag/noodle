using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    // Enum xác định các loại người dùng
    public enum LoaiNguoiDung
    {
        Admin,
        User
    }
    internal class Users
    {
        // Thuộc tính của người dùng
        public string UserName { get; set; }
        public string Password { get; set; }
        public LoaiNguoiDung Role { get; set; } // Vai trò người dùng (Admin hoặc User)

        // Hàm khởi tạo
        public Users(string userName, string password, LoaiNguoiDung role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }

    }
}
