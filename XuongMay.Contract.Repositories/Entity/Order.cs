using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XuongMay.Repositories.Entity;
using System.ComponentModel.DataAnnotations;


namespace XuongMay.Contract.Repositories.Entity
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; }
        public int CreatedByUserId { get; set; }
        public virtual int CreatedByUser { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
