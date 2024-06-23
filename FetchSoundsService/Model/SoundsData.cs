using System.ComponentModel.DataAnnotations;

namespace FetchSoundsService.Model
{
    public class SoundsData
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string link { get; set; }
    }
}
