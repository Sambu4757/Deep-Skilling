public class CustomerRepositoryImpl
    : ICustomerRepository
{
    public string FindCustomerById(int id)
    {
        return $"Customer Found : ID = {id}";
    }
}