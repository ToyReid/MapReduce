// Toy Reid
// CS365 - Lab 4
// 03/07/2018

using System;
using System.Collections.Generic;

public partial class MapReduce<T> {
    protected List<T> data;

    // 0-argument constructor, which simply creates the new generic container.
    public MapReduce() {
        data = new List<T>();
    }

    // Takes a generic parameter and adds it to the generic container.
    public void Add(T x) {
        data.Add(x);
    }

    // Property called Count which returns the number of elements added through the Add function.
    public int Count {
        get {
            return data.Count;
        }
    }

    // Indexer that returns (gets) the given element in your list.
    public T this[int i] {
        get {
            if(i >= Count) throw new IndexOutOfRangeException();
            return data[i];
        }
    }
}