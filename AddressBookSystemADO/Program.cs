using AddressBookSystemADO;

public class Program
{
    public static void Main(string[] args)
    {
        AddressOperations operation = new AddressOperations();
        //operation.CreateDatabase();
        //operation.CreateTable();
        //AddressModel data = new AddressModel()
        //{
        //    FirstName = "a",
        //    LastName = "a",
        //    Address = "a",
        //    City = "a",
        //    State = "a",
        //    Zip = 989898,
        //    PhoneNumber = "9876543210",
        //    Email = "a@a.com"

        //};
        //AddressModel edit
        //    = new AddressModel()
        //{
        //    FirstName = "a",
        //    LastName = "abcd",
        //    Address = "a",
        //    City = "a",
        //    State = "b",
        //    Zip = 12334,
        //    PhoneNumber = "9876543210",
        //    Email = "a@a.com"

        //};
        //operation.executedorNot(operation.AddEmployee(data));
        //operation.executedorNot(operation.EditData(data));
        //operation.executedorNot(operation.DeleteData(data));
        //string citysearch = "a";
        //string statesearch = "b";
        //operation.GetAllEmployeeDetailsByCity(citysearch);
        //operation.DisplayAllDataByCity(citysearch);
        //operation.GetAllEmployeeDetailsByState(statesearch);
        //operation.DisplayAllDataByState(statesearch);
        //operation.SizeByCity();
        //operation.SizeByState();
        //operation.GetPeopleInCitySortedByName("a");
        //operation.CountByType();
        //operation.PersonAsTwoRelation("kanha", "Profession");
        /*List<AddressModel> list = new List<AddressModel>();
        list.Add(new AddressModel()
        {
            FirstName = "a",
            LastName = "a",
            Address = "a",
            City = "a",
            State = "a",
            Zip = 989898,
            PhoneNumber = "9876543210",
            Email = "a@a.com",
            Relation = "Others"
        });
        list.Add(new AddressModel()
        {
            FirstName = "b",
            LastName = "b",
            Address = "b",
            City = "b",
            State = "b",
            Zip = 601201,
            PhoneNumber = "1234567890",
            Email = "berf",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "c",
            LastName = "c",
            Address = "c",
            City = "c",
            State = "c",
            Zip = 3243432,
            PhoneNumber = "1234567890",
            Email = "c@wed.com",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "d",
            LastName = "d",
            Address = "d",
            City = "d",
            State = "d",
            Zip = 3489867,
            PhoneNumber = "1234567890",
            Email = "d@wfeqfef",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "e",
            LastName = "e",
            Address = "e",
            City = "e",
            State = "e",
            Zip = 32332,
            PhoneNumber = "1234567890",
            Email = "e@efef",
            Relation = "Others"
        });
        */
        //Multithreading thread = new Multithreading();
        //thread.UsingWithThread(list);
        //thread.UsingWithThread(list);
        operation.GetAllDetails();

    }
}