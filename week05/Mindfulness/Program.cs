using System;

namespace Mindfulness
{
    class Program
    {   
       // =====================================================================================================
       // EXCEEDING REQUIREMENTS
       // =====================================================================================================
       // To exceed the core requirements I added a tracking system in both the
       // ReflectionActivity and ListingActivity classes. The program keeps track of
       // which random prompts and questions have already been shown to the user.
       // it ensures that no prompt or question is ever repeated during a session
       // until the entire list has been exhausted, Once exhausted, the list resets.
       // =====================================================================================================
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "4")
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                }
                else if (choice == "2")
                {
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                }
                else if (choice == "3")
                {
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                }
                else if ( choice != "4")
                {
                    Console.WriteLine("Invalid choice. Please select a option from 1 to 4.");
                    System.Threading.Thread.Sleep(1500);
                }
            }
        }
    }
}