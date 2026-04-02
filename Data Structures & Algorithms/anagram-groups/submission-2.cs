public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // sort the words in the string 
        // create hashmap
        // use the sorted word as a key in hash map
        // the value of the hashmap key is the list(int)
        //return a list of values from the hash map 

        var map = new Dictionary<string, List<string> >();
        

        foreach (string word in strs){
            // sort word
            char[] characters = word.ToCharArray();
            Array.Sort(characters);
            //build it
            string sorted = new string(characters);

            //checks if key is present in the map
            if(map.ContainsKey(sorted)){
                map[sorted].Add(word);
            }else{
                map[sorted] = new List<string>();
                map[sorted].Add(word);
            }
            
            
        }
        var result = new List<List<string>>(map.Values);
        //return the list of values
        return result ;


    }
}
