public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }
        //compare frequencies
        //character, fequencies
        var map = new Dictionary<char,int>();

        foreach (char i in s){
            //check if it exist in map (to update frequncies)
            if (map.ContainsKey(i)){
                map[i] ++;
            }else{
                map.Add(i,1);
            }
        }
        //if frequency of character reaches less than 0 return false
        foreach (char i in t){
            if(map.ContainsKey(i)){
                map[i] -= 1;
                if (map[i] < 0){
                    return false;
                }
            }else{
                return false;
            }
        }

        return true;

    }
}
