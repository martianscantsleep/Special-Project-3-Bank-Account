using System;
using System.Collections.Generic;
using System.Text;

namespace SP3_BankAccount
{
    internal class Person
    {
        private string firstName, lastName;
        private int age;

        public Person()
        {
            setFirstName("blank");
            setLastName("blank");
            setAge(0);
        }

        public Person(string pFirst, string pLast, int pAge)
        {
            setFirstName(pFirst);
            setLastName(pLast);
            setAge(pAge);
        }

        public void setFirstName(string pFirst)
        { firstName = pFirst; }
        public void setLastName(string pLast)
        { lastName = pLast; }
        public void setAge(int pAge)
        {
            if (pAge >= 0)
                age = pAge;
            else
                Console.WriteLine("Invalid Age");
        }

        public string getFirstName()
        { return firstName; }
        public string getLastName()
        { return lastName; }
        public int getAge()
        { return age; }

        public void Print()
        {
            Console.WriteLine("Name: " + firstName + ", " + lastName);
            Console.WriteLine("Age: " + age);
        }
    }
}
