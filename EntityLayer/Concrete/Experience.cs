using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(3000)]
        public string Content { get; set; }
        public string Date { get; set; }

    }
}
