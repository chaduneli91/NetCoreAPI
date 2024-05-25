using System.ComponentModel.DataAnnotations;

namespace BannersAPI.Entity
{
    public class product
    {
        internal object category;

        public int Id { get; set; }
        [MaxLength(30)]

        public string Name { get; set; }
        public decimal Price { get; set; }

        public category Ccategory { get; set; }

      //  public Guid PackageId { get; set; }

      //  public Package Package { get; set; }

        public string Descripotion { get; set; }
    }
}
