namespace GroupAnagrams
{
    // # Group Anagrams
    // #
    // # Given an array of strings strs, group the anagrams together.
    // # You can return the answer in any order.
    // # An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    // #
    // # Example:
    // # Input: strs = ["eat","tea","tan","ate","nat","bat"]
    // # Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
    // #
    // # Example 2:
    // # Input: strs = ["a"]
    // # Output: [["a"]]
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var anagrams = FindAndGroupAnagram(words);

            foreach (var groupAnagrams in anagrams.Values)
            {
                Console.WriteLine(string.Join(", ", groupAnagrams));
            }
        }

        private static Dictionary<string, List<string>> FindAndGroupAnagram(string[] strs)
        {
            Dictionary<string, List<string>> groupAnagram = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var strOrdered = OrderByStringByLetters(str);

                if (groupAnagram.ContainsKey(strOrdered))
                {
                    groupAnagram[strOrdered].Add(str);
                }
                else
                {
                    List<string> strLists = [str];
                    groupAnagram.Add(strOrdered, strLists);
                }
            }

            return groupAnagram;
        }

        private static string OrderByStringByLetters(string text)
        {
            char[] characters = text.ToArray();

            Array.Sort(characters);

            return new string(characters);
        }
    }
}
