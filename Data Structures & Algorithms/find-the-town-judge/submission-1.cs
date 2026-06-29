public class Solution {
    public int FindJudge(int n, int[][] trust) {
        var trusts = new int[n+ 1];
        var trustby = new int[n + 1];

        foreach (var t in trust){
            trusts[t[0]]++;
            trustby[t[1]]++;
        }

        for(int i = 1; i <= n; i++){
            if(trusts[i] == 0 && trustby[i] == n - 1){
                return i;
            }
        }

        return -1;
    }
}