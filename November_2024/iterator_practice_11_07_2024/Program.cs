using iterator_practice_11_07_2024;

public class Program
{
    public static void Main(string[] args)
    {
        // Storing the elements of GetMyList
        IEnumerable<string> my_slist = GetMyList();

        // Display the elements return from iteration
        foreach (var item in my_slist)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        // Storing the elements of GetMyArray
        IEnumerable<string> myitems = GetMyArray();

        // Display the elements return from the iteration
        foreach (string item in myitems)
        {
            Console.WriteLine(item);
        }
    }

    public static IEnumerable<string> GetMyList()
    {
        // Creating and adding elements in list
        List<string> my_list = new List<string>()
            {
                "Cat", "Goat", "Dog", "Cow"
            };

        // Iteration the elements of my_list
        foreach (string items in my_list)
        {
            // Returning the element after every iteration
            yield return items;
        }
    }

    public static IEnumerable<string> GetMyArray()
    {
        string[] myarray = new string[]
        {
            "Geeks", "geeks123", "1234geeks"
        };

        // Iterating the elements of myarray
        foreach (var items in myarray)
        {
            yield return items.ToString();
        }
    }
}