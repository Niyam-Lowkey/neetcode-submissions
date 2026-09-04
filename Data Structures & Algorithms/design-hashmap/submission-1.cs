public class MyHashMap {
    //Direct Addressing approach.
    int[] map;
    public MyHashMap() {
        map = new int [1000001];
        Array.Fill(map,-1);
    }
    
    
    public void Put(int key, int value) {
        map[key] = value;
    }
    
    public int Get(int key) {
        return map[key];
    }
    
    public void Remove(int key) {
        map[key] = -1;
    }
}