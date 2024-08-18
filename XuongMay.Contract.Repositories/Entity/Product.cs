using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XuongMay.Repositories.Entity;
using System.ComponentModel.DataAnnotations;

namespace XuongMay.Contract.Repositories.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Một Product thuộc về một Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
