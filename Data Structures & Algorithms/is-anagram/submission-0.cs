public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var HashMap = new Dictionary<char, int>();
        
        //putting string 's' into HashMap
        foreach (char i in s.ToCharArray()){
            if (!HashMap.ContainsKey(i)){
                HashMap.Add(i,0);
            }
            if(HashMap.ContainsKey(i)) HashMap[i]++;
        }

        foreach (char i in t.ToCharArray()){
            if(!HashMap.ContainsKey(i)) return false;

            HashMap[i]-=1;
            if (HashMap[i] < 0) return false;
        }
       
        return true;
    
    }
        
        

    
}
