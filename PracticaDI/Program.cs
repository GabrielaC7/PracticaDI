public class Program
{
    public static void Main(string[] args)
    {
        ICustomerRepository customerRepository = new CustomerRepository();
        CustomerService customerService = new CustomerService(customerRepository);

        Customer customer = customerService.FindCustomer(1);

        Console.WriteLine($"ID: {customer.Id}");
        Console.WriteLine($"Nombre: {customer.Name}");
        Console.WriteLine($"Email: {customer.Email}");
        Console.WriteLine($"Teléfono: {customer.PhoneNumber}");
    }
}