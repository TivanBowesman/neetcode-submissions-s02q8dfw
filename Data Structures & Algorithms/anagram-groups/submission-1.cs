public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string> >();

        foreach (string word in strs){
            //Convert to char array
            char[] chars = word.ToCharArray();
            //As words are passed through they are sorted to match the key
            Array.Sort(chars);
            string sortedWord = new string(chars);

            // Add to hashmap
            if (!map.ContainsKey(sortedWord)) {
                //Setup sorted to take in items of type string
                map[sortedWord] = new List<string>();
            }
            map[sortedWord].Add(word);
        }
        return new List<List<string>>(map.Values);
    }
}
  