using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GC_ClassroomLibrary;

namespace CreateClassroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom expNet = new Classroom();

            Console.WriteLine("Welcome to our .Net Class.");
            Console.WriteLine();

            //this list the student roster
            Console.WriteLine("The class has " + expNet.students.Length + "students\n\n");

            string Cont;
            int numInput = 0;
                do {
                

                Console.WriteLine("Which student would you like to learn more about? (enter a number 1 - 6):");

                numInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Student" + numInput + " is " + expNet.students[numInput].Name);
                Console.WriteLine("What would you like to know about" + expNet.students[numInput].Name + "?");
                Console.WriteLine("Enter 'hometown' or 'favorite food'");
                String moreInput = Console.ReadLine();
                if (moreInput == "hometown")
                {
                    Console.WriteLine(expNet.students[numInput].Name + "is from " + expNet.students[numInput].Hometown);

                }
                else if (moreInput == "favorite food")
                {
                    Console.WriteLine(expNet.students[numInput].Name = "favorite food is" + expNet.students[numInput].FavoriteFood);
                }

                else
                {
                    Console.WriteLine("That data does not exist. Try again. Please write request as written.");

                }
                Console.WriteLine("Would you like to know more about other students?y/n");

                Cont = Console.ReadLine();
            } while (Cont == "y");
            Console.WriteLine("Thank and Goodbye!");
            Console.ReadLine();
            
        }
    }
}
