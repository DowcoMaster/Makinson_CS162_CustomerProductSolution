using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProductClasses
{
    public class Customer
    {
        private int id;
        private string email;
        private string firstname;
        private string lastName;
        private string phone;

        public Customer() { }

        public Customer(int CustomerId, string CustomerCode, string desc, string price, string qty)
        {
            id = CustomerId;
            email = CustomerCode;
            firstname = desc;
            lastName = price;
            phone = qty;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Code { get; internal set; }

        public override string ToString()
        {
            return String.Format("Id: {0} Email: {1} FirstName: {2} LastName: {3:C} Phone: {4}", id, email, firstname, lastName, phone);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
                return false;
            else
            {
                Customer other = (Customer)obj;
                return other.Id == Id &&
                    other.Email == Email &&
                    other.FirstName == FirstName &&
                    other.LastName == LastName &&
                    other.Phone == Phone;
            }
        }

        public override int GetHashCode()
        {
            return 13 + 7 * id.GetHashCode() +
                7 * email.GetHashCode() +
                7 * firstname.GetHashCode() +
                7 * lastName.GetHashCode() +
                7 * phone.GetHashCode();
        }


        public static bool operator ==(Customer p1, Customer p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Customer p1, Customer p2)
        {
            return !p1.Equals(p2);
        }

    }
}
