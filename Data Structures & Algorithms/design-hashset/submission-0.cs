public class MyHashSet {
    private List<int> listint;
    public MyHashSet() {
        listint = new List<int>();
    }
    
    public void Add(int key) {
        if(!listint.Contains(key))
            listint.Add(key);
        
    }
    
    public void Remove(int key) {
        if(listint.Contains(key))
            listint.Remove(key);        
    }
    
    public bool Contains(int key) {
        return listint.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */