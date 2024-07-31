public class CustomerRepository : ICustomerRepository
{
    public Customer GetCustomer(int customerId)
    {
        return new Customer
        {
            Id = customerId,
            Name = "Xavier Ramirez",
            Email = "Xavier090@gmail.com",
            PhoneNumber = "829-665-4327"
        };
    }
}
