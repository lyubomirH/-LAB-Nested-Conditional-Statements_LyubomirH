namespace Fruit_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            //double
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            double praise = 2.50;
                            double final_praise = praise * num;
                            Console.WriteLine($"{final_praise:F2}");
                            break;
                        case "apple":
                            double praise_I = 1.20;
                            double final_praise_I = praise_I * num;
                            Console.WriteLine($"{final_praise_I:F2}");
                            break;
                        case "orange":
                            double praise_II = 0.85;
                            double final_praise_II = praise_II * num;
                            Console.WriteLine($"{final_praise_II:F2}");
                            break;
                        case "grapefruit":
                            double praise_III = 1.45;
                            double final_praise_III = praise_III * num;
                            Console.WriteLine($"{final_praise_III:F2}");
                            break;
                        case "kiwi":
                            double praise_IX = 2.70;
                            double final_praise_IX = praise_IX * num;
                            Console.WriteLine($"{final_praise_IX:F2}");
                            break;
                        case "pineapple":
                            double praise_X = 5.50;
                            double final_praise_X = praise_X * num;
                            Console.WriteLine($"{final_praise_X:F2}");
                            break;
                        case "grapes":
                            double praise_XI = 3.85;
                            double final_praise_XI = praise_XI * num;
                            Console.WriteLine($"{final_praise_XI:F2}");
                            break;
                    }
                    break;

                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            double praise1 = 2.70;
                            double final_praise1 = praise1 * num;
                            Console.WriteLine($"{final_praise1:F2}");
                            break;
                        case "apple":
                            double praise2 = 1.25;
                            double final_praise2 = praise2 * num;
                            Console.WriteLine($"{final_praise2:F2}");
                            break;
                        case "orange":
                            double praise3 = 0.90;
                            double final_praise3 = praise3 * num;
                            Console.WriteLine($"{final_praise3:F2}");
                            break;
                        case "grapefruit":
                            double praise4 = 1.60;
                            double final_praise4 = praise4 * num;
                            Console.WriteLine($"{final_praise4:F2}");
                            break;
                        case "kiwi":
                            double praise5 = 3.00;
                            double final_praise5 = praise5 * num;
                            Console.WriteLine($"{final_praise5:F2}");
                            break;
                        case "pineapple":
                            double praise6 = 5.60;
                            double final_praise6 = praise6 * num;
                            Console.WriteLine($"{final_praise6:F2}");
                            break;
                        case "grapes":
                            double praise7 = 4.20;
                            double final_praise_XI = praise7 * num;
                            Console.WriteLine($"{final_praise_XI:F2}");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}