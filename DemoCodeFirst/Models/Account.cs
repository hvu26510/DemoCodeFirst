namespace DemoCodeFirst.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserProfile Profile { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
