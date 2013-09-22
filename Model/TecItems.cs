using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("TecItem")]
    public class TecItem
    {
        [Key]
        public int Id { get; set; }
     
        [Display(Name = "技术类名称")]
        public string CName { get; set; }

        [Display(Name = "岗位名称")]
        public string PositionName { get; set; }

        [Display(Name = "快捷键")]
        public int ShortKey { get; set; }

        [Display(Name = "预设价格")]
        public decimal? PresetPrice { get; set; }

        [Display(Name = "追踪周期")]
        public int? CycleTracing { get; set; }

        [Display(Name = "通用标记")]
        public string CommonMark { get; set; }

        [Display(Name = "拆账参数")]
        public string CollectionPara { get; set; }

        public int Pid { get; set; }

        public TecCategory TecCategory { get; set; }
        
    }
}
