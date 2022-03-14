namespace ObjectOrientedProgramming.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string? Location { get; set; }
        public string? Email { get; set; } 
        public int PhoneNumber { get; set; }
        public List<Customer>? Customers { get; set; }

    }

}
