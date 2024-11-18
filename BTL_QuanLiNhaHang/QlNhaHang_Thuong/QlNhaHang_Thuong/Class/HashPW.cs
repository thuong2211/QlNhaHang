using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QlNhaHang_Thuong.Class
{
    internal class HashPW
    {
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Chuyển mật khẩu sang mảng byte
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                // Băm mật khẩu
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Chuyển mảng byte thành chuỗi hex
                StringBuilder hash = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hash.Append(b.ToString("x2")); // Định dạng hex
                }

                return hash.ToString();
            }
        }
    }
}
