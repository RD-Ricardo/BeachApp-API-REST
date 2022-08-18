using BeachApp.Domain.Entities.Base;

namespace BeachApp.Domain.Entities
{
    public class Role : Entity
    {
        public string NameRole { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}