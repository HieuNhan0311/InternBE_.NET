using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuongMay.Contract.Repositories.Entity
{
    public class TaskProductTracing
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int TaskId { get; set; }
        public Tasks Task { get; set; }

        public required DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Status { get; set; }
    }

}
