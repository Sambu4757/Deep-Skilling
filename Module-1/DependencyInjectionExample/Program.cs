using System;

class Program
{
    static void Main()
    {
        ICustomerRepository repository =
            new CustomerRepositoryImpl();

        CustomerService service =
            new CustomerService(repository);

        service.GetCustomer(101);
    }
}