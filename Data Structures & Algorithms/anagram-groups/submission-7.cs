public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach (var word in strs) {
            var chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (map.ContainsKey(key)) {
                map[key].Add(word);
            } else {
                map[key] = new List<string> { word };
            }
        }

        return map.Values.ToList();
    }
}

//turn word to int 
