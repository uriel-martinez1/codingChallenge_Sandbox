public class Program
{
    public static void Main(string[] args)
    {
        bool isDone = false;
        do
        {
            Console.WriteLine("(1) - Add");
            Console.WriteLine("(2) - Subtract");
            Console.WriteLine("(3) - Quit");

            int choice;
            Int32.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add");
                    break;

                case 2:
                    Console.WriteLine("Subtract");
                    break;
                case 3:
                    Console.WriteLine("Ending the program.");
                    isDone = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (!isDone);


        // count down from 5 to 1

        Console.WriteLine("For loop");
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);

        }
        Console.WriteLine();

        Console.WriteLine("While loop");
        int j = 5;
        while (j > 0)
        {
            Console.WriteLine($"{j}");
            j--;
        }
        Console.WriteLine();

        Console.WriteLine("Do while loop");
        int k = 5;
        do
        {
            Console.WriteLine($"{k}");
            k--;
        } while (k > 0);
        Console.WriteLine();

        for (int x = 0, y = 10; x < 5 && y != 6; x++, y--)
        {
            Console.WriteLine($"{x} -- {y}");
        }
    }
}