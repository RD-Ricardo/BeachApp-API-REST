using BeachApp.Domain.Entities.Base;

namespace BeachApp.Domain.Entities
{
    public class Product : Entity
    {

        public Product()
        {
          
        }
        public Product(string nameProduct, decimal value, string description, int companyId, Company company)
        {
            NameProduct = nameProduct;
            Value = value;
            Description = description;
            CompanyId = companyId;
            Company = company;
        }

      public string  NameProduct { get; set; }  
      public decimal Value  { get; set; }  
      public string Description { get; set; }
      public int CompanyId { get; set; }
      public Company Company { get; set; }
      public int CategoryProductId  { get; set; }
      public CategoryProduct CategoryProduct { get; set; }
      public ICollection<RequestItens> RequestItens { get; set; }
      public void UpdateNameProduct(string nome)
        =>  this.NameProduct = nome;
      
    }
}