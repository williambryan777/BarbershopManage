using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("TecCategory")]
    public class TecCategory
    {
        [Key]
        public int Pid { get; set; }

        [Display(Name = "名称")]
        public string Name { get; set; }

        [Display(Name = "追踪周期")]
        public int? CycleTracing { get; set; }

        [Display(Name = "通用标记")]
        public string CommonMark { get; set; }

        public string Address { get; set; }

        public  virtual ICollection<TecItem> TecItems { get; set; }


    }
}
