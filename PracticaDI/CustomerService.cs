public class CustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Customer FindCustomer(int customerId)
    {
        return _customerRepository.GetCustomer(customerId);
    }
}
