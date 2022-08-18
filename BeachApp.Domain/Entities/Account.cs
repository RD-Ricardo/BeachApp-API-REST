using BeachApp.Domain.Entities.Base;

namespace BeachApp.Domain.Entities
{
    public class Account : Entity
    {
        public Account()
        {
            
        }
        public string NameAccount { get; set; }
        public decimal TotalAccount  { get; set; }
        public bool IsPaid { get; set; }
        public int SunshadeId { get; set; }
        public Sunshade Sunshade { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DatePaid { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}