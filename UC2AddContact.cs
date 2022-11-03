using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23AddressBook
{
    internal class UC2AddContact
    {
        List<string> firstName = new List<string>();
        List<string> lastName = new List<string>();
        List<string> city = new List<string>();
        List<string> state = new List<string>();
        List<int> zip = new List<int>();
        List<int> phoneNumber = new List<int>();
        List<string> email = new List<string>();

        public UC2AddContact(string fName, string lName, string city, string state, int zip, int number, string mail)
        {
            this.firstName.Add(fName);
            this.lastName.Add(lName);
            this.city.Add(city);
            this.state.Add(state);
            this.zip.Add(zip);
            this.phoneNumber.Add(number);
            this.email.Add(mail);
        }

        public void personDetails()
        {
            Console.WriteLine("Name: {0} {1} City: {2} State: {3} Zip: {4} Phone Number: {5} Email: {6}", firstName[0], lastName[0], city[0], state[0], zip[0], phoneNumber[0], email[0]);
        }
    }
}
