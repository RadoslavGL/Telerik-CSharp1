using System;
namespace _15.Age
{
    class Age
    {
        static void Main(string[] args)
        {
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            int yearOfBirth = birthDate.Year;
            int monthOfBirth = birthDate.Month;
            int dayOfBirth = birthDate.Day;

            DateTime todaysDate = DateTime.Now;
            int todaysYear = todaysDate.Year;
            int todaysMonth = todaysDate.Month;
            int todaysDay = todaysDate.Day;

            var currentAge = 0;

            if (monthOfBirth > todaysMonth)
            {
                currentAge = todaysYear - yearOfBirth - 1;
            }
            else
            {
                currentAge = todaysYear - yearOfBirth;
            }

            Console.WriteLine(currentAge);

            var ageIn10Years = currentAge + 10;
            Console.WriteLine(ageIn10Years);

        }
    }
}
