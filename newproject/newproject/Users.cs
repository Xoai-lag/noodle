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

        //Ghi fiile 
        public static bool WriteUsersToFile(string filename, List<Users> users) {
            try
            {
                using(StreamWriter writer=new StreamWriter(filename))
                {
                    foreach (var user in users)
                    {
                        writer.WriteLine($"{user.UserName},{user.Password},{user.Role}");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi ghi file: " + ex.Message);
                return false;
            }
        }

        //Đọc file 
        public static List<Users> ReadUsersFormFile(string filename) {
            List<Users> users = new List<Users>();
            if (File.Exists(filename)) {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            var user = new Users(
                                parts[0], // UserName
                                parts[1], // Password
                                Enum.Parse<LoaiNguoiDung>(parts[2]) // Role
                            );
                            users.Add(user);
                        }
                    }
                }
            }
            else
            { 
                MessageBox.Show("File không tồn tại, đã tạo file mới với người dùng mặc định.");
            }
            return users;
        }

    }
}
