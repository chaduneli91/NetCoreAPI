using System.ComponentModel.DataAnnotations;

namespace BannersAPI.Entity
{
    public class Banners
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string Img { get; set; } 
    }
}
