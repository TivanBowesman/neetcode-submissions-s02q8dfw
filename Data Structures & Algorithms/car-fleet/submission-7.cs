public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var arr = new List<(double time, int pos )>();
        for (int i = 0; i < position.Length; i++){
            var distance = target - position[i];
            double time = (double)distance / speed[i]; 

            arr.Add( (time, position[i]));
        }
        
        //sort arr by time
        //arr.Sort((b, a) => a.pos.CompareTo(b.pos));
        var sorted = arr.OrderByDescending(i => i.pos)
        .ToList();

    
        int fleets = 0;
        double max = double.MinValue;
        foreach(var car in sorted){
            if(car.time > max){
                fleets++; 
                max = car.time;
            }
        }
        return fleets; 
    }
}
//if more than -> new fleet
//cars match
//speed = dist / time

//time = dist / speed 
//sort by pos
