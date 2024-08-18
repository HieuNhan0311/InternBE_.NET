using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace XuongMay.Contract.Repositories.Entity
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        // Một Category có nhiều Product
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }

}
