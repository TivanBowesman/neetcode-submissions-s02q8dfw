public class Solution {
    public bool IsAnagram(string s, string t) {
        var arr = new int[26]; 

        foreach (var c in s){
            arr[c - 'a']++;
        }

        var arr2 = new int[26];
        foreach (var c in t){
            arr2[c - 'a']++;
        }

        return arr.SequenceEqual(arr2);;
    }
}
