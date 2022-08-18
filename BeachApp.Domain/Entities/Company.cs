using BeachApp.Domain.Entities.Base;

namespace BeachApp.Domain.Entities
{
    public class Company  : Entity
    {
       public string NameCompany { get; set; } 
       public string Login { get; set; } 
       public string Password { get; set; } 
       public ICollection<Product> Products { get; set; }
       public ICollection<Employee> Employees { get; set; }
       public ICollection<CategoryProduct> CategoryProducts { get; set; }
       public ICollection<Sunshade> Sunshades { get; set; }
    }
}