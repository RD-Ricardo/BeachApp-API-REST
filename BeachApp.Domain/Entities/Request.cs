using BeachApp.Domain.Entities.Base;

namespace BeachApp.Domain.Entities
{
    public class Request : Entity
    {
        public decimal RequestTotal { get; set; }   
        public decimal RequestItensTotal { get; set; }   
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public  int EmployeeId { get; set; }
        public  Employee Employee { get; set; }
    }
}