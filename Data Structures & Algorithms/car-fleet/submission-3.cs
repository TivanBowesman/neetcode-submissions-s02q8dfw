public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        //sort in terms of closest to target 
        // time = distance / speed
        var len = position.Length;
        var cars = new (int pos, double time)[len];
        for(int i = 0; i < len; i++){
            cars[i] = (position[i], (double)( target - position[i])/ speed[i]);
        }

        Array.Sort(cars, (a,b) => b.pos.CompareTo(a.pos));


        int fleets = 0;
        double max = 0;

        foreach(var car in cars){
            if(car.time > max){
                fleets++;

                max = car.time;
            }
        }
        return fleets;
    }
}
