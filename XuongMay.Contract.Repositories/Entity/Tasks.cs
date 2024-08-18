using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuongMay.Contract.Repositories.Entity
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }

        // Một Task có thể liên kết với nhiều TaskProductTracing
        public ICollection<TaskProductTracing> TaskProductTracings { get; set; } = new List<TaskProductTracing>();
    }

}
