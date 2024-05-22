using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProductClasses
{
    public class CustomerList
    {
        private List<Customer> Customers;

        public CustomerList()
        {
            Customers = new List<Customer>();
        }

        public int Count
        {
            get
            {
                return Customers.Count;
            }
        }

        public void Fill()
        {
            Customers = CustomerDB.GetCustomers();
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(Customers);
        }

        public void Add(Customer Customer)
        {
            Customers.Add(Customer);
        }

        public void Add(int id, string code, string description, decimal price, int quantity)
        {
            Customer p = new Customer(id, code, description, price, quantity);
            Customers.Add(p);
        }

        public void Remove(Customer Customer)
        {
            Customers.Remove(Customer);
        }

        public override string ToString()
        {
            string output = "";
            foreach (Customer p in Customers)
            {
                output += p.ToString() + "\n";
            }
            return output;
        }

        public Customer this[int i]
        {
            get
            {
                return Customers[i];
            }
            set
            {
                Customers[i] = value;
            }
        }

        public Customer this[string code]
        {
            get
            {
                foreach (Customer p in Customers)
                {
                    if (p.Code == code)
                        return p;
                }
                return null;
            }
        }

        public static CustomerList operator +(CustomerList pl, Customer p)
        {
            pl.Add(p);
            return pl;
        }

        public static CustomerList operator -(CustomerList pl, Customer p)
        {
            pl.Remove(p);
            return pl;
        }
    }
}
