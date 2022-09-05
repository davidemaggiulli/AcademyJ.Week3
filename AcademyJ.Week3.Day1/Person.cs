using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyJ.Week3.Day1
{
    public class Person
    {
        /* Stato Interno */
        private string firstName;   //campo privato

        private string lastName;    

        private DateTime birthDate;

        private string address;

        /* **** */

        /** Metodi **/
        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string newAddress)
        {
            address = newAddress;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        /* **** */


        /** Costruttore **/
        public Person(string name, string surname)
        {
            firstName = name;
            lastName = surname;
        }

        /***/
    }
}
