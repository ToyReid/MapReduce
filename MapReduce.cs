public partial class MapReduce<T> {
    protected List<T> data;
    protected int numEl;

    // 0-argument constructor, which simply creates the new generic container.
    public MapReduce() {
        numEl = 0;
        data = new List<T>();
    }

    // Takes a generic parameter and adds it to the generic container.
    public void Add(T in) {

    }

    // Property called Count which returns the number of elements added through the Add function.
    public int Count {
        get {
            return numEl;
        }
    }

    // Indexer that returns (gets) the given element in your list.
    public T IndexOf(int i) {

    }
}