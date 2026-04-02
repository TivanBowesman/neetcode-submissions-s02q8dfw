class TimeMap {
    Map<String, List<String[]>> map;
    public TimeMap() {
        this.map = new HashMap<String,List<String[]>>();        
    }
    
    public void set(String key, String value, int timestamp) {
        //store the key with value and time stamp
        //check if key exist
        if(!map.containsKey(key)){
            map.put(key, new ArrayList<>() );
        }
        map.get(key).add(new String[]{ value, String.valueOf(timestamp) });
    }
    
    public String get(String key, int timestamp) {
        if(!map.containsKey(key)) return "";
        //return value
        
        List<String[]> list = map.get(key);
        int l = 0;
        int r = list.size() - 1;
        String result = "";

        while (l <= r) {
            int mid = l + (r - l) / 2;
            int time = Integer.parseInt(list.get(mid)[1]);

            if (time <= timestamp) {
                // valid candidate, but try to find a newer one
                result = list.get(mid)[0];
                l = mid + 1;
            } else {
                // time too large, go left
                r = mid - 1;
            }
        }

        return result;

        
    }
}
//hashmap<string, int[]>