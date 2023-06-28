using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HK_Database.Models
{
    public class Embedding
    {
        [Key]
        [Required]
        public string EmbeddingId { get; set; }

        [Required]
        public string EmbeddingQuestion { get; set; }

        [Required]
        public string EmbeddingAnswer { get; set;}

        [Required]
        public string QA { get; set;}

        [Required]
        public string EmbeddingVectors { get; set;}

        public string AIFileId { get; set;}
        public AIFile AIFiles { get; set;}

    }
}
