namespace DemoCodeFirst.Models
{
    public class UserProfile
    {
        public int ProfileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Address {  get; set; }
        public int AccountId { get; set; }
        
        public Account account { get; set; }    
    }
}
