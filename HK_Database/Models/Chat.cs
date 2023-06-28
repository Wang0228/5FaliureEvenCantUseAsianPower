using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HK_Database.Models
{
    public class Chat
    {
        [Key]
        [Required]
        public string ChatId { get; set; }

        [Required]
        public DateTime ChatTime { get; set; }

        [Required]
        public string ChatName { get; set; }
        [Required]
        public string UserId { get; set; }

        public User Users { get; set; }

        public ICollection<QAHistory> QAHistory { get; set; }
    }
}
