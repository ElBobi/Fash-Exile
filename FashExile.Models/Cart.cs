namespace FashExile.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ShoppingSessionId { get; set; }
        public virtual ShoppingSession ShoppingSession { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedAt { get; set; } = DateTime.UtcNow;
    }
}