using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23AddressBook
{
    internal class UC5MultiplePerson
    {
        List<string> firstName = new List<string>();
        List<string> lastName = new List<string>();
        List<string> city = new List<string>();
        List<string> state = new List<string>();
        List<int> zip = new List<int>();
        List<int> phoneNumber = new List<int>();
        List<string> email = new List<string>();

        int personCount;

        public void addMultiplePerson()
        {
            
            Console.WriteLine("Enter the number of person: ");
            personCount = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 0; i < personCount; i++)
            {
                Console.WriteLine("Enter the person {0} details:", i+1);
                Console.WriteLine("Enter the First Name: ");
                firstName.Add(Console.ReadLine());
                Console.WriteLine("Enter the last Name: ");
                lastName.Add(Console.ReadLine());
                Console.WriteLine("Enter the city: ");
                city.Add(Console.ReadLine());
                Console.WriteLine("Enter the state: ");
                state.Add(Console.ReadLine());
                Console.WriteLine("Enter the zip: ");
                zip.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Enter the phone number: ");
                phoneNumber.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Enter the email: ");
                email.Add(Console.ReadLine());
                
            }
        }

        public void printPersons()
        {
            for(int i = 0; i <personCount; i++)
            {
                Console.WriteLine("Person {0} details are:",i+1);
                Console.WriteLine("Name {0} {1}", firstName[i], lastName[i]);
                Console.WriteLine("City: " + city[i]);
                Console.WriteLine("State: " + state[i]);
                Console.WriteLine("Zip: " + zip[i]);
                Console.WriteLine("Phone Number: " + phoneNumber[i]);
                Console.WriteLine("Email: " + email[i]);
            }
        }
        
    }
}
