using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {
        public string firstName;
        public string lastName;
        public string emailId;
        public string phoneNumber;
        public string passWord;


        public User()
        {

        }

        public User(String firstname, String lastname, string emailId, string PhoneNumber, string Password)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.emailId = emailId;
            this.phoneNumber = PhoneNumber;
            this.passWord = Password;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Emailld { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

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
            if (regex.IsMatch(name) && name.Length > 3)
            {

                name = LastName;


            }
            else
            {
                Console.WriteLine("sorry invalid");
            }
        }
        public void verifyEmail()
        {
            Regex regex = new Regex("^[a-z1-9]{1,}(.[a-z1-9]{1,}){0,}@[a-z]{1,}[.]{1}[a-z]{1,}(.[a-z]{1,}){0,}$");
            Console.Write("Enter the  EmailId");

            string Email = Console.ReadLine();
            Match match1 = regex.Match(Email);
            if (regex.IsMatch(Email))
            {

                Email = Emailld;


            }
            else
            {
                Console.WriteLine("The Email Id should be in \" abc.xyz@bl.co.in \" format\n" +
                    "(xyz & in parts optional");
            }
        }
        public void phoneNo()
        {
            Regex regex = new Regex(" ^[0 - 9]{ 2 }[0 - 9]{ 9}$");
            Console.Write("Enter the  Phone Number");

            string Phone = Console.ReadLine();
            Match match1 = regex.Match(Phone);
            if (regex.IsMatch(Phone))
            {

                Phone = PhoneNumber;


            }
            else
            {
                Console.WriteLine("The phone number should have\n" +
                    "1. 2 digit country code followed by space \n" +
                    "2. 10 digit number");
            }
        }
        public void PassWord()
        {
            Regex regex = new Regex("^[A-Za-z0-9]{8,}$");
            Console.Write("Enter the  PassWord");

            string PassWord = Console.ReadLine();
            Match match1 = regex.Match(PassWord);
            if (regex.IsMatch(PassWord))
            {

                PassWord = Password;

            }
            else
            {
                Console.WriteLine("Password needs to be minimum 8 characters");
            }


        }
    }

}
