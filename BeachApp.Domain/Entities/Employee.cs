using BeachApp.Domain.Entities.Base;

namespace BeachApp.Domain.Entities
{
    public class Employee : Entity
    {
        public string  NameEmployee{ get; set; }
        public string  LoginEmployee { get; set; }
        public string  Password { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreate { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Request> Request { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}