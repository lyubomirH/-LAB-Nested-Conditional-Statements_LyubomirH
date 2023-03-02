using System.ComponentModel;

namespace miss_and_MR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            switch (gender)
            {
                case "m":
                    if (age < 16)
                    {
                        Console.WriteLine("Master");
                    }
                    else
                    {
                        Console.WriteLine("Mr.");
                    }
                    break;
                case "f":
                   if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    else
                    {
                        Console.WriteLine("Ms.");
                    }
                   break;
            }

        }

    }