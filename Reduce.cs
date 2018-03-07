using System.Threading.Tasks;

public partial class MapReduce<T> {
    // Takes two generic parameters (left and right), executes the given operation and returns a single generic data.
    public delegate T ModReduce(T lhs, T rhs);

    // Serially, and synchronously loop through the internal data and execute the function given by the delegate
    // parameter. Notice that the Reduce function does not modify any of the internal data.
    public void Reduce(ModReduce mr) {

    }
    
    public async Task ReduceAsync() {
        
    }
}