namespace Web.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int ComputerId { get; set; }
        public decimal Price { get; set; }
        public virtual Computer computer { get; set; }
        public virtual Order order { get; set; }
    }
}
