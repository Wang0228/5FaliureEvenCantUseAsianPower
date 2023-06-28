using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HK_Database.Models
{
    public class User
    {
        [Key]
        [Required]
        public string UserId { get; set; }

        [Required]
        public string UserPassword { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserEmail { get; set; }
        
        public string ApplicationId { get; set; }
        public Application Applications { get; set; }

        public ICollection<Chat> Chats { get; set; }
    }
}
