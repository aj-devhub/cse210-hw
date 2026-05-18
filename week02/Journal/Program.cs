using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        

        List<string> prompts = new List<string>
        {
            "What made you happy today?",
            "What did you learn today?",
            "What was challenging today?"
        };

        while (true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            
            Console.WriteLine("\n1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Random rand = new Random();
                string prompt = prompts[rand.Next(prompts.Count)];

                Console.WriteLine("\nPrompt: " + prompt);
                journal.AddEntry(prompt);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == "4")
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}

/*
EXTRA CREDIT NOTE:
I used a CSV file to store journal entries.
Each entry includes date, prompt, and response.
I used StreamWriter and File.ReadAllLines for saving and loading data.
*/