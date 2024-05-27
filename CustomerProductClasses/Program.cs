using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerProductClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerList();
        }
        static void TestCustomerList()
        {
            CustomerList list = new CustomerList();

            Console.WriteLine("Testing CustomList");

            // Test the constructor
            Console.WriteLine("Testing CustomList constructor:");
            Console.WriteLine("Count. Expecting 0. Actual: " + list.Count);

            // Test the Add method
            Console.WriteLine("\nTesting Add method:");

            Customer p1 = new Customer(1, "example@gmail.com", "Quentin", "Dowco", "123-456-7890");
            Customer p2 = new Customer(2, "example@hotmail.com", "John", "Doe", "431-231-3213");

            Console.WriteLine("Testing Customer list add.");
            Console.WriteLine("BEFORE Count.  Expecting 0. " + list.Count);
            list.Add(p1);
            Console.WriteLine("AFTER Add Count.  Expecting 1. " + list.Count);
            Console.WriteLine("ToString.  Expect one Customer " + list.ToString());
            list += p2;
            Console.WriteLine("AFTER Second Add Count.  Expecting 2. " + list.Count);
            Console.WriteLine("ToString.  Expect two Customers " + list.ToString());
            Console.WriteLine();

            // TestCustomerSave
            list = new CustomerList();
            list.Add(p1);
            list += p2;
            list.Save();
            list.Fill();
            Console.WriteLine("Testing Customer list save and fill.");
            Console.WriteLine("After Fill Count.  Expecting 2. " + list.Count);
            Console.WriteLine("ToString.  Expect two Customers " + list.ToString());
            Console.WriteLine();

            // Test to see if Customers are equal
            // these 2 objects should be equal.
            list = new CustomerList();
            p1 = new Customer(2, "example@hotmail.com", "John", "Doe", "431-231-3213");
            p2 = new Customer(2, "example@hotmail.com", "John", "Doe", "431-231-3213");
            Customer p1Reference = p1;

            Console.WriteLine("Testing Customer equals.");
            Console.WriteLine("2 references to the same object.  Expecting true. " + p1.Equals(p1Reference));
            Console.WriteLine("2 object that have the same properties should be equal.  Expecting true. " + p1.Equals(p2));
            Console.WriteLine();

            // Test the Remove method
            // test fails before I add equals to Customer
            list = new CustomerList();
            p1 = new Customer(2, "example@hotmail.com", "John", "Doe", "431-231-3213");

            list.Fill();
            Console.WriteLine("Testing Customer list remove.");
            Console.WriteLine("Before remove Count.  Expecting 2. " + list.Count);
            Console.WriteLine("ToString.  Expect two Customers " + list.ToString());
            list -= p1;
            Console.WriteLine("After remove Count.  Expecting 1. " + list.Count);
            Console.WriteLine("ToString.  Expect just Customer 1 " + list.ToString());
            Console.WriteLine();

            // Test any other methods or properties as needed

            Console.WriteLine("\nNow taking a look at our Customer database.\n");
            List<Customer> customers = CustomerDB.GetCustomers();
            // Get the count of customers
            Console.WriteLine("Total Customers: " + customers.Count);

            // Save customers to an XML file
            CustomerDB.SaveCustomers(customers);
            Console.WriteLine("Saved contents to XML file");
            // Reading from the list
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
            Console.WriteLine("\nTestCustomList completed.\n");
        }
    }
}