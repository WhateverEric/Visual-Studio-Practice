using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // BELOW IS HOW YOU USE STRINGS AND INTS AS
            string characterName = "Eric";
            int characterAge = 24;

            Console.WriteLine(characterName + " doesn't like his life at the moment");
            Console.WriteLine(characterName + " is " + characterAge + " years old");
            Console.WriteLine("A lot of people wonder why " + characterName + " doesn't like his life");
            Console.WriteLine(characterName + " says that life is meaningless and we're all fake happy");

            Console.ReadLine();

            // BELOW ARE THE DIFFERENT TYPES OF DATA C# CAN USE
            string phrase = "Unversity of Eric";
            char grade = 'B';
            int age = 30;
            double gpa = 3.2;
            bool isMale = true;

            // BELOW IS THE NEXT SECTION ON WORKING WITH STRINGS
            string school = "Giraffe Academy" + " is cool";
            Console.WriteLine(school);

            Console.WriteLine(school.Length); //LENGTH WILL HELP YOU FIND OUT HOW MANY CHARACTERS ARE IN A STRING

            Console.WriteLine(school.ToUpper()); //ToUpper and ToLower will make the entire string upper or lowercase 
            Console.WriteLine(school.ToLower());

            Console.WriteLine(school.Contains("Academy")); //Contains will tell you if a string contains something you are searching for

            Console.WriteLine(school[0]); //This is an index code to show which character is at that position which is "G"

            Console.WriteLine(school.IndexOf("Academy")); //IndexOf tells you the position at which your chosen string starts at

            Console.WriteLine(school.Substring(9, 2)); //Substring lets you grab a piece of your string at your desired position as well as grabbing as many desired characters afterwards

            Console.ReadLine();

            // BELOW IS HOW TO WORK WITH NUMBERS
            Console.WriteLine(10 + 5); //You can use numbers to solve math problems as well as ORDER OF OPERATIONS
            Console.WriteLine(100 - 20);
            Console.WriteLine(5 * 5);
            Console.WriteLine(10 / 2);
            Console.WriteLine(5 % 2); //This is a modulus operator, which divides the number and then prints our the remainder in the console
            Console.WriteLine(2 + 2 * 10);
            int num = 10; //You can also store numbers in variables
            Console.WriteLine(num);

            Console.WriteLine(Math.Abs(-40)); //These are MATH METHODS which are just bits of code to execute a math operator
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(100, 80));
            Console.WriteLine(Math.Min(100, 80));
            Console.WriteLine(Math.Round(65.7));
            Console.WriteLine(Math.Floor(70.9));
            Console.WriteLine(Math.Ceiling(70.1));
            Console.ReadLine();

            //THIS NEXT SECTION IS HOW TO GET USER INPUT
            Console.Write("Enter your name: "); //cONSOLE.WRITE prints out a string on the same line
            string username = Console.ReadLine();
            Console.Write("Enter you age: ");
            string userage = Console.ReadLine();

            Console.WriteLine("Hello " + username + "! You are " + userage);
            Console.ReadLine();

            //THIS NEXT SECTION IS HOW TO BUILD A CALCULATOR USING USER INPUT
            int num1 = Convert.ToInt32("45"); //The Convert method converts a string into a number, but a number has to be inside of the string
            Console.WriteLine(num1 + 6);

            Console.ReadLine();

            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number1 + number2);
            Console.ReadLine();

            Console.Write("Enter a number: "); //THIS IS HOW YOU CAN ADD DECIMALS TOGETHER BY USING THE DOUBLE METHOD
            double number3 = Convert.ToDouble(Console.ReadLine()); //USING THE CONVERT TO DOUBLE IS PROBABLY BEST PRACTICE
            Console.Write("Enter another number: ");
            double number4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(number3 + number4);
            Console.ReadLine();

            //THIS NEXT SECTION COVERS HOW TO BUILD A MAD LIBS GAME
            string color, food, celebrity; //You can define multiple variables at once like this
            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a food: ");
            food = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine("Violets are " + food);
            Console.WriteLine("I love " + celebrity);
            Console.ReadLine();

            //THIS IS NEXT SECTION IS ABOUT ARRAYS
            int[] luckyNumbers = { 1, 2, 3, 4, 5, 6 }; //ARRAYS are just like variables except they can have more than one value

            string[] friends = new string[5]; //This is another way to make ARRAYS, by specifying how many values you can store in an Array
            friends[0] = "Jim";            //And then manually inserting a value at every index
            friends[1] = "Josh";

            luckyNumbers[1] = 900; //This is how you insert a number in an Array

            Console.WriteLine(luckyNumbers[2]);
            Console.ReadLine();
        }
    }
}
