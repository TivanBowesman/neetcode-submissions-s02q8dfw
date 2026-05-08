public class MyHashSet {
    Dictionary<int,int> map; 
    public MyHashSet() {
        map = new Dictionary<int,int>();
    }
    
    public void Add(int key) {
        map[key] = 1;
    }
    
    public void Remove(int key) {
        map[key] = 0;
    }
    
    public bool Contains(int key) {
        if(map.ContainsKey(key) ){
            if(map[key] == 0){
                return false;
            }
            return true; 
        }
        return false;
        
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */