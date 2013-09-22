using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("UerInfo")]
    public class UerInfo
    {
       [Key]
        public int UserInfoId { get; set; }
        [Display(Name = "用户名称")]
        public string UserName { get; set; }
        [Display(Name = "电子邮件")]
        [MaxLength(50)]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Display(Name = "语言")]
        public string Language { get; set; }
        public string Sport { get; set; }
        public int Age { get; set; }
        public string Reader { get; set; }

    }
}
