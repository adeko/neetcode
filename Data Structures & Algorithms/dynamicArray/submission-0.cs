public class DynamicArray {

    int[] array;
    int size;
    int capacity;
    
    public DynamicArray(int capacity) {
        if (capacity < 0) throw new ArgumentOutOfRangeException();
        this.array = new int[capacity];
        this.size = 0;
        this.capacity = capacity;
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
        array[i] = n;
    }

    public void PushBack(int n) {
        if (size == capacity) Resize();
        array[size] = n;
        size += 1;
    }

    public int PopBack() {
        if (size == 0) throw new IndexOutOfRangeException();
        size -= 1;
        return array[size];
    }

    private void Resize() {
        capacity *= 2;
        int[] arrayNew = new int[capacity];
        for (int i = 0; i < size; i++)
            arrayNew[i] = array[i];
        array = arrayNew;
    }

    public int GetSize() {
        return size;
    }

    public int GetCapacity() {
        return capacity;
    }
}
