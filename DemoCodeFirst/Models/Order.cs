namespace DemoCodeFirst.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int OrderStatus { get; set; }

        public int AccountID { get; set; }
        public Account account { get; set; }
    }
}
