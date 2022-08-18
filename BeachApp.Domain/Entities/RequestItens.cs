using BeachApp.Domain.Entities.Base;

namespace BeachApp.Domain.Entities
{
    public class RequestItens : Entity
    {
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public int RequestId{ get; set; }
        public Request Request { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}