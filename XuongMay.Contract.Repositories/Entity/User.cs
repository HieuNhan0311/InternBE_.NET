using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuongMay.Contract.Repositories.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string FullName { get; set; }
        public string Role { get; set; } // Ví dụ: "Admin", "Employee", "Customer"

        // Một User có thể thực hiện nhiều Order
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
