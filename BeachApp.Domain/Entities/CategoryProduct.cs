using BeachApp.Domain.Entities.Base;

namespace BeachApp.Domain.Entities
{
    public class CategoryProduct : Entity
    {
        public string  NameProduct { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}