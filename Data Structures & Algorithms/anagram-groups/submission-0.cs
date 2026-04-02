public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string> >();

        foreach (string word in strs){
            //convert to char array
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string sortedWord = new string(chars);

            // Add to hashmap
            if (!map.ContainsKey(sortedWord)) {
                //setup sorted to take in items of type string
                map[sortedWord] = new List<string>();
            }
            map[sortedWord].Add(word);
        }
        return new List<List<string>>(map.Values);
    }
}
  