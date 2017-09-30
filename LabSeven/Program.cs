using System;
using System.Collections.Generic;

namespace LabSeven
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> myClassList = PopulateClassList();
            int studentIndex = 0;
            Console.WriteLine("Welcome to our C# class! Let's learn about our students.");
            bool run = true;
            while (run == true)
            {
                try
                {
                    Console.Write("Please enter a number 1-12: ");
                    studentIndex = int.Parse(Console.ReadLine());
                    if (studentIndex >= 1 && studentIndex <= 12)
                    {
                        Student selectedStudent = myClassList[studentIndex - 1];

                        Console.WriteLine("Student " + studentIndex + " is " + selectedStudent.getName() + ".");
                        RequestStudentInfo(selectedStudent);

                    }
                    else
                    {
                        Console.WriteLine("Sorry, but that is not a valid student number. Please enter a number 1 - 12");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("I'm sorry, that is not a valid response. Please enter a number 1 - 12.");
                }

                run = Continue();
                Console.WriteLine();
            }

        }

        static bool Continue()
        {
            Console.Write("Would you like to know more about the students in our class (Y/N)? ");
            string input = Console.ReadLine().ToUpper();
            bool doAgain;
            if (input == "Y")
            {
                doAgain = true;
            }
            else if (input == "N")
            {
                doAgain = false;
            }
            else
            {
                Console.WriteLine("That is not a valid response. Please try again.");
                doAgain = Continue();
            }

            return doAgain;
        }

        static List<Student> PopulateClassList()
        {
            List<Student> classList = new List<Student>();
            classList.Add(new Student("Lauren Babcock", "Plainwell, MI", "Cheeseburgers"));
            classList.Add(new Student("Molly Guthrie", "Rockford, MI", "Noodles"));
            classList.Add(new Student("Michelle Jokisch Polo", "Ecuador", "Spaghetti"));
            classList.Add(new Student("Rebecca Allard", "Charlevoix, MI", "Pizza"));
            classList.Add(new Student("Brianna Jael", "Fairfield, CA", "Gumbo"));
            classList.Add(new Student("Tammy Cole", "Grand Rapids, MI", "Maru Sushi"));
            classList.Add(new Student("Karina Lopez", "Holland, MI", "Tacos"));
            classList.Add(new Student("Anel Guel", "Juarez", "Pizza"));
            classList.Add(new Student("Tommy Waalkes", "Raleigh, NC", "India Red Curries"));
            classList.Add(new Student("Lisa Dewey", "Los Angeles, CA", "Mushroom Masala Dosa"));
            classList.Add(new Student("Jonaca Hudson", "Lansing, MI", "Sushi"));
            classList.Add(new Student("Tanvi Sathe", "India", "Chicken Biryani"));
            
            return classList;
        }

        static void RequestStudentInfo(Student myStudent)
        {
            Console.Write("What would you like to know about " + myStudent.getName() + "? Enter 'hometown' or 'favorite food': ");
            string requestedInfo = Console.ReadLine();

            if (requestedInfo.ToLower() == "hometown")
            {
                Console.WriteLine(myStudent.getName() + " is from " + myStudent.getHometown());
            }
            else if (requestedInfo.ToLower() == "favorite food")
            {
                Console.WriteLine(myStudent.getName() + "'s favorite food is " + myStudent.getFavFood());
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid request. Please type 'hometown' or 'favorite food'");
            }
        }
    }
}
