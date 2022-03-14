namespace ObjectOrientedProgramming.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid? AddressID { get; set; } 
        public bool gender { get; set; }

        public Address? address { get; set; }
    }
}
