using System.ComponentModel.DataAnnotations;

namespace HK_Database.ViewModels
{
    public class AllMemberViewModel
    {
        [Display(Name = "會員姓名")]
        public string MemberName { get; set; }

        [Display(Name = "會員信箱")]
        public string MemberEmail { get; set; }

        [Display(Name = "會員電話")]
        public string MemberPhone { get; set; }

        [Display(Name = "會員帳號")]
        public string MemberAccount { get; set; }

        [Display(Name = "密碼")]
        public string MemberPassword { get; set; }
       
    }
}
