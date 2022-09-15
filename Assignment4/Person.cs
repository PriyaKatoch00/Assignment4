using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    
        class Person
        {
            private String FirstName;
            private string LastName;
            private string Email;
            private DateTime Dob;

            public string SetfirstName
            {
                get
                {
                    return FirstName;
                }
                set
                {
                    FirstName = value;
                }
            }
            public string SetLastName
            {
                get
                {
                    return LastName;
                }
                set
                {
                    LastName = value;
                }
            }


            public string SetEmail
            {
                set
            {
                
                string[] items = value.Split('@'); 
                if (items.Length != 2)
                {
                    throw new ArgumentException("Invalid email address");
                }
                Email = value; 
            }
        }
            public DateTime SetDob
            {
                set
                {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Date of birth can't be in the future");
                }
                Dob = value;
            }
            }
            public Person(String First, String Last, String email, DateTime DOfB)
            {
                FirstName = First;
                LastName = Last;
                Email = email;
                Dob = DOfB;
            }

            public Person(String First, String Last, String email)
            {
                FirstName = First;
                LastName = Last;
                Email = email;
            }

            public Person(String First, String Last, DateTime DOfB)
            {
                FirstName = First;
                LastName = Last;
                Dob = DOfB;

            }
       

        static void Main(string[] args)
            {
            Console.WriteLine("Enter details for a person\n");
            Console.Write(" First name : ");
            string first = Console.ReadLine();
            Console.Write(" Last name : ");
            string last = Console.ReadLine();
            Console.Write(" Email address : ");
            string email = Console.ReadLine();
            Console.Write(" Date of birth : ");
            string dob = Console.ReadLine();
            DateTime dateofbirth = DateTime.Parse(dob);
            Person p = new Person(first, last, email, dateofbirth);
            Console.WriteLine();
            Console.WriteLine("The person entered is : {0} {1}", p.FirstName, p.LastName);
            Console.WriteLine("Email address is: {0}", p.Email);
            Console.WriteLine("Date of birth is: {0}", p.Dob.ToShortDateString());

        }


        }
    }
