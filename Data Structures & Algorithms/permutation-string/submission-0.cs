public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        //edge case
        if (s1.Length > s2.Length) return false; 

        //find a subset 
        // count how many of the chars in the subset
        // if the char count ever goes above s1's return false
        //return true at the end of this

        //place char count of s1 and s2 into array
        int[] s1Array = new int[26]; // A - Z
        int[] s2Array = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            s1Array[s1[i] - 'a']++;
            s2Array[s2[i] - 'a']++;
        }
        //compare first window
        if (Matches(s1Array,s2Array)) return true;

        for (int i = s1.Length; i < s2.Length; i++) {
            s2Array[s2[i] - 'a']++;                     // Add right char
            s2Array[s2[i - s1.Length] - 'a']--;         // Remove left char

            if (Matches(s1Array, s2Array)) return true;
        }

        return false;
    }

    public bool Matches(int[] a, int[] b) {
        for (int i = 0; i < 26; i++) {
            if (a[i] != b[i]) return false;
        }
        return true;
    }
}
