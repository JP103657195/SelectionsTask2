using System;

namespace SelectionsTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string age;
            Console.Write("Please enter your age: ");
            age = Console.ReadLine();

            string gender;
            Console.Write("Please enter your gender: ");
            gender = Console.ReadLine();

            if (gender == "Female")
            {
                Console.Write("Female is ");
            }

            else if (gender == "female")
            {
                Console.Write("Female is ");
            }

            else if (gender == "Male")
            {
                Console.Write("Male is ");
            }

            else if (gender == "male")
            {
                Console.Write("Male is ");
            }

            int ageNum = int.Parse(age);

            if (ageNum >= 18)
            {
                Console.Write("an adult.");
            }

            else 
            {
                Console.Write("not an adult.");
            }

        }
    }
}
