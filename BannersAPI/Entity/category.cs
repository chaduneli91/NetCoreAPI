using System.ComponentModel.DataAnnotations;

namespace BannersAPI.Entity
{
    public class category
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string name { get; set; }

        public string code { get; set; }

        public string description { get; set; }
    }
}
