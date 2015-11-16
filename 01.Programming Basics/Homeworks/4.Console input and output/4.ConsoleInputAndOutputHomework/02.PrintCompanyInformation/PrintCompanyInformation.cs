using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Enter the following data: ");
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager's fist name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager's last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager's age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Manager's phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: " + (string.IsNullOrEmpty(faxNumber) ? "(no fax)" : faxNumber));
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + 
                "(age: " + age + ", tel. " + managerPhone + ")");
        }
    }
}
