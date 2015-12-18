using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string id;
        private string address;
        private string mobilePhone;
        private string email;

        public Customer(
            string firstName,
            string middleName,
            string lastName,
            string id,
            string address,
            string mobilePhone,
            string email,
            CustomerType type)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Type = type;

            this.Payments=new List<Payment>();
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.ValidateStringValue(value, "firstName");
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                this.ValidateStringValue(value, "middleName");
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                this.ValidateStringValue(value, "lastName");
                this.lastName = value;
            }
        }

        public string Id
        {
            get { return this.id; }
            private set
            {
                this.ValidateStringValue(value, "id");
                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("id", "Id must be exactly 10 symbols long");
                }
                this.id = value;
            }
        }

        public string Address
        {
            get { return this.address; }
            private set
            {
                this.ValidateStringValue(value, "address");
                this.address = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            private set
            {
                this.ValidateStringValue(value, "mobilePhone");
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentOutOfRangeException("email", "Email must either be null or should contain \'@\'");
                }
                this.email = value;
            }
        }

        private void ValidateStringValue(string name, string variableName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(
                    variableName,
                    string.Format("{0} must not be null or whitespace", variableName));
            }

            if (name.Length <= 1)
            {
                throw new ArgumentOutOfRangeException(
                    variableName,
                    string.Format("{0} must be longer than 1 symbol", variableName));
            }
        }

        public List<Payment> Payments { get; private set; }

        public CustomerType Type { get; private set; }

        public void AddPayment(Payment payment)
        {
            this.Payments.Add(payment);
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if (customer == null)
            {
                return false;
            }

            if (Object.Equals(this.FirstName, customer.FirstName))
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
        {
            return Customer.Equals(firstCustomer, secondCustomer);
        }

        public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
        {
            return Customer.Equals(firstCustomer, secondCustomer);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public object Clone()
        {
            var newCustomer = new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Id,
                this.Address,
                this.MobilePhone,
                this.Email,
                this.Type);

            foreach (var payment in this.Payments)
            {
                newCustomer.AddPayment(payment);
            }

            return newCustomer;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("First name: {0} Middle name: {1} Last name: {2}",
                this.FirstName,
                this.MiddleName,
                this.LastName));
            result.AppendLine(string.Format("Id: {0} Email: {1} Phone number: {2} ",
                this.Id,
                this.Email,
                this.MobilePhone));

            return result.ToString();
        }

        public int CompareTo(Customer customer)
        {
            if (string.Compare(this.FirstName, customer.FirstName, StringComparison.Ordinal) != 0)
            {
                if (string.Compare(this.FirstName, customer.FirstName, StringComparison.Ordinal) < 0)
                {
                    return 1;
                }

                return -1;
            }

            if (string.Compare(this.Id, customer.Id, StringComparison.Ordinal) != 0)
            {
                if (string.Compare(this.Id, customer.Id, StringComparison.Ordinal) < 0)
                {
                    return 1;
                }

                return -1;
            }

            return 0;
        }
    }
}
