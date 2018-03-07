using System.Threading;

public partial class MapReduce<T> {
    public delegate T ModMap(T);

    // Take as a parameter the delegate. The Map function must use the
    // Parallel class to execute the delegate map function in parallel.
    public void Map(ModMap mm) {

    }
}