using BeachApp.Domain.Entities.Base;

namespace BeachApp.Domain.Entities
{
    public class Sunshade : Entity
    {
        public string NameSunshade { get; set; }
        public string ColorName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}