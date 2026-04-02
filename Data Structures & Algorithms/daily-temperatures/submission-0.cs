public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        var result = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++){
            int count = 0;
            for (int j = i +1;j<temperatures.Length;j++){
                count++;
                if (temperatures[i] < temperatures[j]){
                    result[i] = count;
                    break;
                }
            }
        }

        
        return result;
    }
}
