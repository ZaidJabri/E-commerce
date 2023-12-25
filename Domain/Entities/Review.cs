using Domain.Enums;

namespace Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string Description { get; set; }

        public Rating Rating { get; set; }

    }
}
