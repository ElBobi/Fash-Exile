namespace FashExile.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedAt { get; set; } = DateTime.UtcNow;
    }
}