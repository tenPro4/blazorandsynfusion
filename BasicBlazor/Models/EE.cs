using System.ComponentModel.DataAnnotations;

namespace BasicBlazor.Models
{
    public class EE1
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Range(1,100)]
        public int? ENumber { get; set; }

        public void LoadRecords()
        {

        }
    }
}
