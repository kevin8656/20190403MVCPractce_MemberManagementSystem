using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MemberManagementSystem.Models
{
    [MetadataType(typeof(MemberMetadata))]
    public partial class Member
    {
        public class MemberMetadata
        {
            [DisplayName("會員編號：")]
            public int Id { get; set; }

            [DisplayName("會員姓名")]
            [Required(ErrorMessage = "請輸入會員姓名")]
            [StringLength(15, MinimumLength = 3, ErrorMessage = "會員姓名需介於3-15字元")]
            public string Name { get; set; }

            [DisplayName("會員年齡")]
            [Required(ErrorMessage = "請輸入會員年齡")]
            [Range(0, 100, ErrorMessage = "會員年齡大於0")]
            public int Age { get; set; }

            [DisplayName("會員地址")]
            [Required(ErrorMessage = "請輸入會員地址")]
            public string Address { get; set; }

            [DisplayName("會員電話")]
            [Required(ErrorMessage = "請輸入會員電話")]
            [RegularExpression(@"^09\d{2}-\d{6}$", ErrorMessage = "請輸入正確的電話號碼格式 09xx-xxxxxx")]
            public string Tel { get; set; }
        }
    }
}