public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        //figure out how long it will take for each car to reach target
        //speed = s / t;
        //t = distance/ speed;

        var len = position.Length; 
        var pairs = new int[len][];
        var cars = new(int pos, double time)[len];

        for(int i = 0; i < len; i++){
            cars[i] = (position[i], (double)(target - position[i]) / speed[i]);
        }

        //sort in order of closest to the target
        Array.Sort(cars,(a,b) => b.pos.CompareTo(a.pos) );

        int fleets = 0; 
        double max = 0;

        foreach(var car in cars){
            if(car.time > max){
                fleets++;

                //update max
                max = car.time;
            }
        }

        return fleets;
    }
}
