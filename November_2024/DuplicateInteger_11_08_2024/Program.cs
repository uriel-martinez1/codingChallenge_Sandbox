public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4 };
        bool result = DuplicateInteger(nums);
        Console.WriteLine(result);

        // to overwrite an entire array, you need to replace it with a new array
        nums = new int[] { 1, 2, 3, 3 };
        result = DuplicateInteger(nums);
        Console.WriteLine(result);

        nums = new int[] { 1, 2, 3, 1, 2, 3 };
        result = DuplicateInteger(nums);
        Console.WriteLine(result);
    }

    public static bool DuplicateInteger(int[] numbers)
    {
        bool result = false;

        // create a dictionary to add the numbers and their count
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        // we do a frequency counter for all the values inside the array
        foreach (int n in numbers)
        {
            if (frequency.ContainsKey(n))
            {
                frequency[n]++;
                result = true;
            }
            else
            {
                frequency[n] = 1;
            }
        }
        return result;
    }

    public static bool DuplicateIntegerUsingAHashSet(int[] numbers)
    {
        // lets create an bool variable that holds result -- changes if the result matches
        bool result = false;

        // we will create a hashset to hold count
        HashSet<int> numbersSeen = new HashSet<int>();
        
        // we can create a frequency counter that goes through each element in the given array and break once it finds a duplicate number
        foreach (int n in numbers)
        {
            if (numbersSeen.Contains(n))
            {
                result = true;
            }
            else
            {
                numbersSeen.Add(n);
            }
        }
        
        // else lets return false
        return result;
    }
}