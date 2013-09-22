using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 商品123123
    /// </summary>
    [Table("Commodity")]
    public class Commodity
    {
        [Key]
        public int CId { get; set; }

        [Display(Name = "编号")]
        public int Code { get; set; }

        [Display(Name = "名称")]
        public string CName { get; set; }

        [Display(Name = "快捷键")]
        public int ShortKey { get; set; }

        [Display(Name = "预设价格")]
        public decimal? PresetPrice { get; set; }

        [Display(Name = "预设成本")]
        public decimal? PresetCosting { get; set; }

        [Display(Name = "预设存放量")]
        public decimal? PresetStore { get; set; }

        [Display(Name = "预设供应商")]
        public string PresetSupply { get; set; }

        [Display(Name = "单位")]
        public string Unit { get; set; }

        [Display(Name = "厂牌")]
        public string ProductName { get; set; }

        [Display(Name = "追踪周期")]
        public int? CycleTracing { get; set; }

        [Display(Name = "通用标记")]
        public string CommonMark { get; set; }

        [Display(Name = "拆账参数")]
        public string CollectionPara { get; set; }

        public int CcId { get; set; }
        public CommodityCategory CommodityCategory { get; set; }
    }
}