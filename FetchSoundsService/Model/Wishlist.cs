using System.ComponentModel.DataAnnotations;

namespace FetchSoundsService.Model
{
    public class Wishlist
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int SoundID { get; set; }
    }
}
