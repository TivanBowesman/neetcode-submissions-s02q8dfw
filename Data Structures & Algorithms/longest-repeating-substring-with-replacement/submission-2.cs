public class Solution {
    public int CharacterReplacement(string s, int k) {
        int max = 0;
        //arr[(s[r] - 'A')] += 1; 
        var FreqArray = new int[26];

        int l = 0;
        for(int r  = 0; r < s.Length; r++){
            //add char to freq array
            FreqArray[(s[r] - 'A')] += 1;

            int WindowSize = r - l + 1;
            int MaxFreq = FreqArray.Max();
            //check the valid condition
            while(WindowSize - MaxFreq > k){
                //decrease the freq of l in the list (Popping it)
                FreqArray[(s[l] - 'A')]--;

                l++;
                //update max freq and window
                WindowSize = r - l + 1;
                MaxFreq = FreqArray.Max();
            }
            
            //find max with VALID array
            max = Math.Max(max, r - l + 1);
        }

        return max;
    }
}
