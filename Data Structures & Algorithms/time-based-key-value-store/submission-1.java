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
        String result = "";

        for(int i = list.size() - 1; i >= 0; i--){
            int time = Integer.parseInt(list.get(i)[1]);
            if(time <= timestamp){
                result = list.get(i)[0];
                break;
            }
        }

        return result;
        
    }
}
//hashmap<string, int[]>