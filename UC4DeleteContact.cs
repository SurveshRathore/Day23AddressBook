using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day23AddressBook
{
    internal class UC4DeleteContact
    {
        List<string> firstName = new List<string>();
        List<string> lastName = new List<string>();
        List<string> city = new List<string>();
        List<string> state = new List<string>();
        List<int> zip = new List<int>();
        List<int> phoneNumber = new List<int>();
        List<string> email = new List<string>();

        public UC4DeleteContact(string fName, string lName, string city, string state, int zip, int number, string mail)
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
            if(firstName.Count > 0)
                Console.WriteLine("Name: {0} {1} City: {2} State: {3} Zip: {4} Phone Number: {5} Email: {6}", firstName[0], lastName[0], city[0], state[0], zip[0], phoneNumber[0], email[0]);
            else
                Console.WriteLine("Address Book is empty.");
        }
        
        public void deletePersonDetails (string name)
        {
            int index = firstName.IndexOf(name);
            if(index != -1)
            {
                firstName.RemoveAt(index);
                lastName.RemoveAt(index);
                city.RemoveAt(index);
                state.RemoveAt(index);
                zip.RemoveAt(index);
                phoneNumber.RemoveAt(index);
                email.RemoveAt(index);
                Console.WriteLine("Person Contact is deleted from the address book");
            }
            else
            {
                Console.WriteLine("No person found.");
            }
            
        }
    }
}
