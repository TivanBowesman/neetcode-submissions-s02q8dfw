public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>( );

        foreach(var asteroid in asteroids){
            var curr = asteroid;

            //check for neg
            while(stack.Count > 0 && curr < 0 && stack.Peek() > 0){
                var diff = curr + stack.Peek();

                //apply the rules
                if(diff == 0){
                    stack.Pop();
                    curr = 0;
                }else if(diff > 0){
                    curr = 0;
                }else if(diff < 0){
                    stack.Pop();
                }
            }


            if (curr != 0){
                stack.Push(curr);
            }

            
        }

        return stack.Reverse().ToArray();
    }
}