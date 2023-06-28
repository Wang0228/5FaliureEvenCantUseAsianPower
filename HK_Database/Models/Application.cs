using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HK_Database.Models
{
    public class Application
    {
        [Key]
        [Required]
        public string ApplicationId { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Parameter { get; set; }

        public string MemberId { get; set; }
        public Member Members { get; set; }


        public ICollection<AIFile>AIFiles { get; set; }

        public ICollection<User> Users { get; set; }

        
        
    }
}
