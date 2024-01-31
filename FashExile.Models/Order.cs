namespace FashExile.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal Total { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedAt { get; set; }= DateTime.UtcNow;
    }
}