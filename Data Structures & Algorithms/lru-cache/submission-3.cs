public class LRUCache {
    private Dictionary<int, LinkedListNode<(int key, int val)>> map;
    private LinkedList<(int key, int val)> list;
    private int capacity;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        map = new Dictionary<int, LinkedListNode<(int, int)>>();
        list = new LinkedList<(int, int)>();
    }

    public int Get(int key) {
        if (!map.ContainsKey(key)) return -1;

        // move to front (most recently used)
        var node = map[key];
        list.Remove(node);
        list.AddFirst(node);
        return node.Value.val;
    }

    public void Put(int key, int value) {
        if (map.ContainsKey(key)) {
            list.Remove(map[key]);
        }

        var node = new LinkedListNode<(int, int)>((key, value));
        list.AddFirst(node);
        map[key] = node;

        if (map.Count > capacity) {
            // evict least recently used (back of list)
            var lru = list.Last;
            map.Remove(lru.Value.key);
            list.RemoveLast();
        }
    }
}
