public class CustomerService
{
    private readonly ICustomerRepository repository;

    public CustomerService(
        ICustomerRepository repository)
    {
        this.repository = repository;
    }

    public void GetCustomer(int id)
    {
        string customer =
            repository.FindCustomerById(id);

        System.Console.WriteLine(customer);
    }
}