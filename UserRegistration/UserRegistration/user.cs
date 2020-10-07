using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {
        public string firstName;
        public string lastName;
        


        public User()
        {
           
        }

        public User(String firstname, String lastname)
        {
            this.firstName = firstname;
            this.lastName = lastname;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void verifyfirstName()
        {
            Regex regex = new Regex("^[A-Z]");
            Console.Write("enter the first name");
            string fname = Console.ReadLine();
            Match match = regex.Match(fname);
            if (regex.IsMatch(fname) && fname.Length > 3)
            {

                fname = FirstName;

            }
            else
            {
                Console.WriteLine("invalid");
            }
            



        }
        public void verifylastName()
        {
            Regex regex = new Regex("^[A-Z]");
            Console.Write("Enter the  last name");
            
            string name = Console.ReadLine();
            Match match1 = regex.Match(name);
            if (regex.IsMatch(name)&& name.Length > 3)
            {

                name = LastName;
                

            }
            else
            {
                Console.WriteLine("sorry invalid");
            }
        }
        
    }
    
    
}
