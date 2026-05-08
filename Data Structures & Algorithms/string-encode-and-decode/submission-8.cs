public class Solution {

    public string Encode(IList<string> strs) {
        var builder = new StringBuilder();
        foreach(var s in strs){
            builder.Append(s + "£"); 
        }

        return builder.ToString();
    }

    public List<string> Decode(string s) {
        var arr = s.Split("£");
        var ans = arr.ToList();
        ans.RemoveAt(ans.Count - 1);
        return ans;
   }
}
