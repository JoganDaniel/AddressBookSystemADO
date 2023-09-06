using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemADO
{
    public class Multithreading
    {
        AddressOperations operations = new AddressOperations();
        public void UsingWithoutThread(List<AddressModel> list)
        {
            DateTime start = DateTime.Now;
            foreach (var data in list)
            {
                operations.AddEmployee(data);
            }
            DateTime end = DateTime.Now;

            Console.WriteLine("Duration without Thread " + (end - start));
        }
        public void UsingWithThread(List<AddressModel> list)
        {
            DateTime start = DateTime.Now;
            foreach (var data in list)
            {

                Task threadss = new Task(() =>
                {
                    Console.WriteLine("Being Added " + data.FirstName);
                    operations.AddEmployee(data);
                    Console.WriteLine("Added " + data.FirstName);
                });
                threadss.Start();
                threadss.Wait();

            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Duration with Thread " + (end - start));
        }
    }
}
