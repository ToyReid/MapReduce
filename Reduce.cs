// Toy Reid
// CS365 - Lab 4
// 03/07/2018

using System.Threading.Tasks;

public partial class MapReduce<T> {
    // Takes two generic parameters (left and right), executes the given operation and returns a single generic data.
    public delegate T ModReduce(T lhs, T rhs);

    // Serially, and synchronously loop through the internal data and execute the function given by the delegate
    // parameter. Notice that the Reduce function does not modify any of the internal data.
    public T Reduce(ModReduce mr) {
        T ret = data[0];

        for (int i = 1; i < Count; i++) {
            ret = mr(ret, data[i]);
        }

        return ret;
    }
    
    public async Task<T> ReduceAsync(ModReduce mr) {
        return await Task.Run(() => {
            return Reduce(mr);
        });
    }
}