// Toy Reid
// CS365 - Lab 4
// 03/07/2018

using System.Threading.Tasks;

public partial class MapReduce<T> {
    public delegate T ModMap(T x);

    // Take as a parameter the delegate. The Map function must use the
    // Parallel class to execute the delegate map function in parallel.
    public void Map(ModMap mm) {
        Parallel.For(0, 10, i => {
            data[i] = mm(data[i]);
        });
    }
}