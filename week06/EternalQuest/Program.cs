using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        while (true)
        {
            Console.WriteLine("\n==== Eternal Quest ====");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Exit");

            Console.Write("Select: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("1. Simple  2. Eternal  3. Checklist");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    manager.AddGoal(new SimpleGoal(name, desc, points));
                }
                else if (type == "2")
                {
                    manager.AddGoal(new EternalGoal(name, desc, points));
                }
                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == "2")
            {
                manager.DisplayGoals();
                Console.Write("Select goal number: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(index);
            }
            else if (choice == "3")
            {
                manager.DisplayGoals();
            }
            else if (choice == "4")
            {
                manager.DisplayScore();
            }
            else if (choice == "5")
            {
                manager.SaveGoals("goals.txt");
            }
            else if (choice == "6")
            {
                manager.LoadGoals("goals.txt");
            }
            else if (choice == "7")
            {
                break;
            }
        }
    }
}
