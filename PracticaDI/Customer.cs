public class Customer
{
       public int Id { get; set; }
        public String? Name { get; set; } 
        public String? Email { get; set; } 
        public String? PhoneNumber { get; set; }
    }


public interface ICustomerRepository
{
    Customer GetCustomer(int customerId);
}

