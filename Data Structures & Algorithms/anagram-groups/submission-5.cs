public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new List<List<string>>();

        var map = new Dictionary<string, List<string> >();

        //sort
        //use sorted as a key - orig as value
        foreach(string s in strs){
            var charArr = s.ToCharArray();
            Array.Sort(charArr);
            var sorted = new string(charArr);

            if (map.ContainsKey(sorted)){
                map[sorted].Add(s);
            }else{
                map[sorted] = new List<string>();
                map[sorted].Add(s);
            }
        }

        foreach(var s in map.Keys){
            res.Add(map[s]);
        }
        
        return res;
    }
}
