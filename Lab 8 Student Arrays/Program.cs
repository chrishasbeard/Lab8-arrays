using System;

namespace Lab_8_Student_Arrays
{
    class Program
    {
        static string[] students = { "1) Sandy Walters", "2) June Boggard", "3) Dave Imhoff", "4) Howard McDuck", "5) Spiro Vamvakas" };
        static string[] age = { "23", "31", "19", "24", "45" };
        static string[] occupation = { "Continual Improvements Specialist", "Mechanical Engineer", "Materials Specialtist", "Bartender", "Club Owner" };
        static string[] dreamJob = { "Site Coordinator", "Director of New Business Development", "Senior Engineer", "Club Owner", "Unemployed Billionaire" };

       static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to my small college classroom, of my 5 students which would you like to know more about? ");
                       
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine(students[i]);
                }

                int index = ValidateRange("Which student would you like to know more about? Enter a number 1 - 5", 0, students.Length);
                index--;

                Console.WriteLine($" Ah, yes. My student {students[index]}");

                MoreStudentInfo(index);

            } while (KeepQuestioning("Do you want to learn about another student? (y/n):"));
        }    
       
        public static void MoreStudentInfo(int index)
        {          
            string question = GetUserInput("Would you like to learn about the student? (Enter either age, occupation, dream job, or 'no')");//
            switch (question)
            {
                case "age":
                    Console.WriteLine(age[index]);
                    MoreStudentInfo(index);
                    break;
                case "occupation":
                    Console.WriteLine(occupation[index]);
                    MoreStudentInfo(index);
                    break;
                case "dream job":
                    Console.WriteLine(dreamJob[index]);
                    MoreStudentInfo(index);
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Sorry invalid!");
                    MoreStudentInfo(index);
                    break;
            }

        }

        public static bool KeepQuestioning(string question)
        {
            string answer = GetUserInput(question);
            if (answer == "y")
            {

                Console.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int ValidateRange(string message, int min, int max)
        {
            int number = ParseString(message);
            if (number > min && number <= max)
            {
                return number;
            }
            else
            {
                return ValidateRange(message, min, max);
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;            
        }

        public static int ParseString(string message)
        {
            try
            {
                string input = GetUserInput(message);
                int number = int.Parse(input);
                return number;
            }
            catch
            {
                return ParseString(message);
            }
        }
    }
}
