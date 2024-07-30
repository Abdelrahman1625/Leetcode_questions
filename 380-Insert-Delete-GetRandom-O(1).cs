public class RandomizedSet {
    private Dictionary<int, int> dict;
    private List<int> list;
    private Random random;

    public RandomizedSet() {
        dict = new Dictionary<int, int>();
        list = new List<int>();
        random = new Random();
    }
    
    public bool Insert(int val) {
        if (dict.ContainsKey(val))
            return false;
        
        dict[val] = list.Count;
        list.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if (!dict.ContainsKey(val))
            return false;
        
        int lastElement = list[list.Count - 1];
        int idx = dict[val];
        
        list[idx] = lastElement;
        dict[lastElement] = idx;
        
        list.RemoveAt(list.Count - 1);
        dict.Remove(val);
        
        return true;
    }
    
    public int GetRandom() {
        return list[random.Next(list.Count)];
    }
}