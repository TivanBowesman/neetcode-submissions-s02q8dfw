public class LRUCache {
    private Dictionary<int, int> map;
    private Queue<int> q;
    private int capacity;

    public LRUCache(int capacity) {
        this.capacity = capacity; // fixed reversed assignment
        map = new Dictionary<int, int>();
        q = new Queue<int>(); // fixed Stack<int>() → Queue<int>()
    }

    public int Get(int key) {
        if (!map.ContainsKey(key)) {
            return -1;
        }

        // move key to the end of the queue to mark it as recently used
        var tempList = new List<int>();
        while (q.Count > 0) {
            int item = q.Dequeue();
            if (item == key) continue; // skip current key
            tempList.Add(item);
        }

        foreach (var item in tempList) {
            q.Enqueue(item);
        }
        q.Enqueue(key); // add it back as most recently used

        return map[key];
    }

    public void Put(int key, int value) {
        // If key already exists, remove it from queue
        if (q.Contains(key)) {
            var tempList = new List<int>();
            while (q.Count > 0) {
                int item = q.Dequeue();
                if (item == key) continue;
                tempList.Add(item);
            }
            foreach (var item in tempList) {
                q.Enqueue(item);
            }
        }
        // If key doesn’t exist and we’re at capacity, evict the least recently used (front)
        else if (q.Count >= capacity) {
            int lru = q.Dequeue();
            map.Remove(lru);
        }

        // Add new key as most recently used
        q.Enqueue(key);
        map[key] = value;
    }
}


//use stack for 

//stack LIFO
//queue FIFO

//if array[length] != 0 && its not 0



//use  queue and dictionary

//if count is bigger than capacity dequeue and remove assciated KV