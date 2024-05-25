using System.ComponentModel.DataAnnotations;

namespace BannersAPI.Entity
{
    public class Package
    {
        public Package()
        {
            PackageProducts = new List<PackageProduct>();
        }
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }    
        public List<PackageProduct> PackageProducts { get; set; }
        public string Description { get; set; }
      
    }
}
