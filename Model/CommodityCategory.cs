using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 商品类别
    /// </summary>
    [Table("CommodityCategory")]
    public class CommodityCategory
    {

        [Key]
        public int CcId { get; set; }

        [Display(Name = "名称")]
        public string Name { get; set; }

        [Display(Name = "追踪周期")]
        public int? CycleTracing { get; set; }

        [Display(Name = "通用标记")]
        public string CommonMark { get; set; }

        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
