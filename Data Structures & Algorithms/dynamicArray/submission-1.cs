public class DynamicArray {
    private List<int> _list;
    public DynamicArray(int capacity) {
        _list = new List<int>(capacity);
    }

    public int Get(int i) {
        return _list[i];
    }

    public void Set(int i, int n) {
        _list[i] = n;
    }

    public void PushBack(int n) {
        if(_list.Count == _list.Capacity){
            Resize();
        }
        
       
        _list.Add(n);
    }

    public int PopBack() {
        if(_list.Any()){
            var backNum = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return backNum;
        }
        return 0;
    }

    private void Resize() {
        _list.Capacity = _list.Capacity * 2;
    }

    public int GetSize() {
        return _list.Count();
    }

    public int GetCapacity(){
        return _list.Capacity;
    }
}
