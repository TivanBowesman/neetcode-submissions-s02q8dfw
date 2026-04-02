public class Solution {

    public string Encode(IList<string> strs) {
        //takes in list 
        //convert to string 
        string res = "";
        foreach (var word in strs){
            //get word length
            int length = word.Length;
            res += $"{length}#" + word;
        }
        Console.WriteLine(res);
        return res;

    }

    public List<string> Decode(string s) {
    var list = new List<string>();
    int i = 0;

    while (i < s.Length) {
        int j = i;

        // Move j to find the '#' separator
        while (s[j] != '#') {
            j++;
        }

        // Parse the length from s[i..j]
        int length = int.Parse(s.Substring(i, j - i));

        // Start of actual word is right after '#'
        int start = j + 1;

        // Extract the word using the parsed length
        string word = s.Substring(start, length);
        list.Add(word);

        // Move i to the beginning of the next encoded part
        i = start + length;
    }

    return list;
}

}
