﻿using AddressBookSystemADO;

public class Program
{
    public static void Main(string[] args)
    {
        AddressOperations operation = new AddressOperations();
        //operation.CreateDatabase();
        //operation.CreateTable();
        AddressModel data = new AddressModel()
        {
            FirstName = "a",
            LastName = "a",
            Address = "a",
            City = "a",
            State = "a",
            Zip = 989898,
            PhoneNumber = "9876543210",
            Email = "a@a.com"

        };
        AddressModel edit
            = new AddressModel()
        {
            FirstName = "a",
            LastName = "abcd",
            Address = "a",
            City = "a",
            State = "a",
            Zip = 12334,
            PhoneNumber = "9876543210",
            Email = "a@a.com"

        };
        //operation.executedorNot(operation.AddEmployee(data));
        operation.executedorNot(operation.EditData(data));
    }
}