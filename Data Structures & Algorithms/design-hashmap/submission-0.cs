public class MyHashMap {
    private List<(int key,int value)> data;
    public MyHashMap() {
        data = new List<(int key,int value)>();// ((int key, int value)) called touple.
    }
    
    public void Put(int key, int value) {
        for (int i=0; i < data.Count; i++){
            if(data[i].key == key){
                data[i] = (key,value);
                return;
            }            
        }
            data.Add((key,value));
    }
    
    public int Get(int key) {
        foreach(var item in data){
            if(item.key == key){
                return item.value;
            }
        }
            return -1;
    }
    
    public void Remove(int key) {
        for (int i = 0; i < data.Count; i++){
            if(data[i].key == key){
                data.RemoveAt(i);
                break;
            }
        }
    }
}
