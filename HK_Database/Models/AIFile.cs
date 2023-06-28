using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HK_Database.Models
{
    public class AIFile
    {
        [Key]
        [Required]
        public string AIFileId { get; set; }

        [Required]
        public string AIFileType { get; set; }

        [Required]
        public string AIFilePath { get; set; }

        public string ApplicationId { get; set; }

        public Application Applications { get; set; }

        public ICollection<Embedding> Embeddings { get; set; }
    }
}
