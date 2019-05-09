using System;

namespace deliverable2
{
    class MainClass
    {
        public static string SuggestActivity(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "stock car racing";

                case 2:
                    return "hiking";

                case 3:
                    return "skydiving";

                case 4:
                    return "to Taco Bell";

                default:
                    return "back to the beginning and enter an integer between one and four!";
            }
        }

        public static string SuggestTransportation(int choice)
        {
            if (choice == 0)
            {
                return "sneakers";
            }
            else if (choice < 5)
            {
                return "a sedan";
            }
            else if (choice < 11)
            {
                return "a Volkswagen bus";
            }
            else
            {
                return "an airplane";
            }
        }

        public static void Main(string[] args)
        {
            int userActivity;
            int userCompanions;

            Console.WriteLine("Hello! What are you in the mood for this weekend?");
            Console.WriteLine("Select one integer number from the following options:");
            Console.WriteLine("1. Action");
            Console.WriteLine("2. Chilling");
            Console.WriteLine("3. Danger");
            Console.WriteLine("4. Good Food");
            userActivity = Convert.ToInt32(Console.ReadLine());

            while (userActivity < 1 || userActivity > 4)
            {
                Console.WriteLine("Hold your horses! That entry wasn't valid–please go back one step and select an integer between 1 and 4.");
                Console.WriteLine("1. Action");
                Console.WriteLine("2. Chilling");
                Console.WriteLine("3. Danger");
                Console.WriteLine("4. Good Food");
                userActivity = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Okay, and how many people are you bringing with you?");
            userCompanions = Convert.ToInt32(Console.ReadLine());

            while (userCompanions < 0)
            {
                Console.WriteLine("Wait a minute, are you sure you entered a positive integer? Go back a step and try that again, please!");
                Console.WriteLine("How many people are you bringing with you?");
                userCompanions = Convert.ToInt32(Console.ReadLine());
            }

            string activitySuggestion = SuggestActivity(userActivity);
            string transportationSuggestion = SuggestTransportation(userCompanions);

            Console.WriteLine("In that case, you should take " + transportationSuggestion + " and go " + activitySuggestion + "! Have a great time!");
            Console.WriteLine("Goodbye!");
        }
    }
}