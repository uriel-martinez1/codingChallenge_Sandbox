using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_practice_11_07_2024
{
    public class IterationEx
    {
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
    }
}
