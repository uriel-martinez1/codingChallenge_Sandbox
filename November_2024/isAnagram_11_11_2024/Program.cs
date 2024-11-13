public class Program
{
    public static void Main(string[] args)
    {
        /*
            Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.
            An anagram is a string that contains the exact same characters as another string, 
            but the order of the characters can be different.
        
        */

        string s = "xx";
        string t = "x";
        bool result = IsAnagram(s, t);
        Console.WriteLine(result);

        Console.WriteLine("------------------------------");

        string x = "cat";
        string y = "tac";
        bool result2 = IsAnagramUsingSortingAndCharacterArray(x, y);
        Console.WriteLine(result2);

        Console.WriteLine("------------------------------");

        string a = "jar";
        string b = "jam";
        bool result3 = IsAnagramUsingHashTable(a, b);
        Console.WriteLine(result3);

        Console.WriteLine("------------------------------");

        // Sort a string
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        Array.Sort(cars);
        foreach (string item in cars)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsAnagram(string s, string t)
    {
        // lets create a boolean variable called isAnagram and set it to false
        bool isAnagram = false;
        
        // if the string length of both strings don't match, lets return false
        if (s.Length != t.Length)
        {
            return isAnagram;
        }

        // we need to go each character in string s and see if the string t contains that character
        foreach (char ch in s)
        {
            // if the character is found in the string t, lets remove it from the string
            if (t.Contains(ch))
            {
                // we need to grab the index position of the character
                int index = t.IndexOf(ch);
                // lets remove the single character using the Remove method
                t = t.Remove(index, 1);
            }
        }
        // if string t is empty
        if (t.Length == 0)
        {
            // lets return true
            isAnagram = true;
        }
        // otherwise we return false
        return isAnagram;
    }

    public static bool IsAnagramUsingSortingAndCharacterArray(string s , string t)
    {
        if(s.Length != t.Length)
        {
            return false;
        }

        // we convert both strings into character arrays
        char[] sSort = s.ToCharArray();
        char[] tSort = t.ToCharArray();

        // We will use the Array.Sort() method to take each character array and sort the array in alphabetical order or from smallest to greatest
        Array.Sort(sSort);
        Array.Sort(tSort);

        // we will now see if both sequences of characters are arranged in both arrays in a similar manner -- the result will be either a bool of true of false
        return sSort.SequenceEqual(tSort);
    }

    public static bool IsAnagramUsingHashTable(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        // we will create a couple of dictionaries that will hold each unique character found in both words and their respective counts found for each character -- frequency counter
        Dictionary<char, int> countS = new Dictionary<char, int>();
        Dictionary<char, int> countT = new Dictionary<char, int>();

        // iterate through each character in a string and record the frequency of every character
        for (int i = 0; i < s.Length; i++)
        {
            countS[s[i]] = countS.GetValueOrDefault(s[i], 0) + 1;
            countT[t[i]] = countT.GetValueOrDefault(t[i], 0) + 1;
        }

        // lets check if the count for unique characters is the same and also every character in countS has the same count in countT
        return countS.Count == countT.Count && !countS.Except(countT).Any();
    }
}