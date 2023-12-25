using Domain.Enums;

namespace Domain.Entities
{
    public class UserPayment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public PaymentType PaymentType { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? IsDefault { get; set; }
    }
}
