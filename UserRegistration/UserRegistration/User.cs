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
        public string PassWord { get; set; }

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
        private bool VerifyPassWord(string Pass)
        {
            Regex regex = new Regex("^[A-Za-z0-9]{8,}$");
            return (regex.IsMatch(Pass));

        }
        private bool VerifyPassWord2(string Pass)
        {
            Regex regex = new Regex("^.*[A-Z]+.*$");
            return (regex.IsMatch(Pass));
        }
        private bool VerifyPassWord3(string pass)
        {
            Regex regex = new Regex("^.*[1-9]+.*$");
            return (regex.IsMatch(pass));
        }
        private bool VerifyPassword4(string pass)
        {
            Regex regex = new Regex("^[A - Za - z0 - 9] *[!@#$%&*_-][A-Za-z0-9]*$");
            return (regex.IsMatch(pass));
        }
        public void PassWordVerification()
        {
            Console.Write("Enter the Password :");
            string Pass = Console.ReadLine();
            if (VerifyPassWord(Pass) && VerifyPassWord2(Pass) && VerifyPassWord3(Pass)&& VerifyPassword4(Pass)) 
            {
                PassWord = Pass;
                Console.WriteLine("correct password");
            }
               
           
            else
            {
                Console.WriteLine("Password needs to have \n" +
                    "1. Minimum 8 characters\n" +
                    "2. At least 1 upper case character\n" +
                    "3. At least 1 numeric value\n"+
                    "4. At least 1 numeric character");
            }
        }
        public void VerifiedEmailList()
        {
            List<string> emailList = new List<string>();
            emailList.Add("abc@yahoo.com");
            emailList.Add("abc-100@yahoo.com");
            emailList.Add("abc.100@yahoo.com");
            emailList.Add("abc111@yahoo.com");
            emailList.Add("abc-100@abc.net");
            emailList.Add("abc.100@abc.com.au");
            emailList.Add("abc@1.com");
            emailList.Add("abc@gmail.com.com");
            emailList.Add("abc+100@gmail.com");

            

            
            Regex regex = new Regex("^[a-z0-9-+]+([.][a-z0-9+-]+)?@[a-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$");

            foreach (string email in emailList)
            {
                if (regex.IsMatch(email))
                    Console.WriteLine(email + "- VALID");
                else
                    Console.WriteLine(email + "- INVALID");
            }


        }

    }
}
