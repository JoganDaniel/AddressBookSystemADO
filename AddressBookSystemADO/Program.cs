using AddressBookSystemADO;

public class Program
{
    public static void Main(string[] args)
    {
        AddressOperations operation = new AddressOperations();
        operation.CreateDatabase();
    }
}