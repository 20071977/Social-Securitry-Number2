using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Social_Securitry_Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your Social Security Number: (yyyyMMdd-xxxx)");
            string socialSecurityNumber = Console.ReadLine();

            string genderNumberString = socialSecurityNumber.Substring(11, 1);
            int genderNumber = int.Parse(genderNumberString);
            bool isFemale = genderNumber % 2 == 0;
            if (isFemale)
            {
                Console.WriteLine("Female");
            }
            else
            {
                Console.WriteLine("Male");
            }

            string birthDateString = socialSecurityNumber.Substring(0, 8);
            DateTime birthDate = DateTime.ParseExact(birthDateString, "yyyyMMdd", CultureInfo.InvariantCulture);
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate.Month > DateTime.Today.Month ||
                birthDate.Month == DateTime.Today.Month && birthDate.Day > DateTime.Now.Day)
            {
                age = age - 1;
            }
            Console.WriteLine(age);

            Console.Clear();


            
            Console.WriteLine($"Name:                   "+firstName+ " " + lastName);
            
            Console.WriteLine("Social Security Number: "+socialSecurityNumber);
            
            if (isFemale)
            {
                Console.WriteLine("Gender:                 Female");
            }
            else
            {
                Console.WriteLine("Gender:                 Male");
            }
            Console.WriteLine("Age:                    "+age);

            if(birthDate.Year>1901&&birthDate.Year<1927)
            {
                Console.WriteLine("Generation:             The G.I.Generation");
            }
            else if (birthDate.Year<1945&&birthDate.Year>1928)
            {
                Console.WriteLine("Generation:             The Silent Generation");
            }
            else if(birthDate.Year>1946&&birthDate.Year<1964)
            {
                Console.WriteLine("Generation:Baby Boomers Generation");
            }
            else if(birthDate.Year>1965&&birthDate.Year<1980)
            {
                Console.WriteLine("Generation:             Thirteener");
            }
            else if(birthDate.Year>1981&&birthDate.Year<1996)
            {
                Console.WriteLine("Generation:             Millennial");
            }
            else if(birthDate.Year>1997&&birthDate.Year<2012)
            {
                Console.WriteLine("Generation:             Generation Z");
            }
            else if(birthDate.Year>2013)
            {
                Console.WriteLine("Generation:       Generation Alpha");
            }


            
            
            
            
            
            







        }    
    }
}
