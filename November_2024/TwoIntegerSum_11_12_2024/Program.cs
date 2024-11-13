using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        int[] input1 = { 3, 4, 5, 6 };
        int[] result1 = TwoSum(input1, 7);
        PrintResultForIntegerArray(result1);

        int[] input2 = { 4, 5, 6 };
        int[] result2 = TwoSum(input2, 10);
        PrintResultForIntegerArray(result2);

        int[] input3 = { 5, 5 };
        int[] result3 = TwoSum(input3, 10);
        PrintResultForIntegerArray(result3);

        int[] result4 = TwoSumUsingOnePassHashMap(input1, 7);
        PrintResultForIntegerArray(result4);

        int[] input4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] result5 = TwoSumUsingOnePassHashMap(input4, 17);
        PrintResultForIntegerArray(result5);
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        int[] output = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                // lets look at the current index for i and lets see the next few integers in the array
                if (nums[i] + nums[j] == target)
                {
                    // lets return both items in an array
                    output = new int[] { i, j };
                    Array.Sort(output);
                    return output;
                }
            }
        }
        return output;
    }

    public static void PrintResultForIntegerArray(int[] nums)
    {
        StringBuilder output = new StringBuilder("[");
        for (int i = 0; i < nums.Length; i++)
        {
            output.Append($"{nums[i]},");
        }
        output.Replace(',', ']', output.Length - 1, 1);
        Console.WriteLine(output);
    }

    public static int[] TwoSumUsingOnePassHashMap(int[] nums, int target)
    {
        // value : index
        Dictionary<int, int> prevMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            // lets determine what is the different between the target and the value inside nums within the current index
            int diff = target - nums[i];

            // if we find the value of the difference inside the frequency dictionary, lets grab that the index position
            if (prevMap.ContainsKey(diff))
            {
                return new int[] { prevMap[diff], i };
            }
            // else we set the integer as the key and the index as its value
            int CurrentIntAsKey = nums[i];
            prevMap[CurrentIntAsKey] = i;
        }

        // if no two values add to the target, lets return null
        return null;
    }
}