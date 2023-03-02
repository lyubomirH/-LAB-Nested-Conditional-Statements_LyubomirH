namespace Work_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int H = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (H >= 10 && H <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                    default: 
                    Console.WriteLine("closed");
                    break;
            }
        }
    }
}