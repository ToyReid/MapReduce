// Toy Reid
// CS365 - Lab 4
// 03/07/2018

using System;
using System.Collections;

public class DataReaderEnum : IEnumerator {
    protected int position;
    protected double[] _data;

    public DataReaderEnum(double[] data) {
        position = -1;
        _data = data;
    }

    public bool MoveNext() {
        position++;
        return (position < _data.Length);
    }

    public void Reset() {
        position = -1;
    }

    object IEnumerator.Current {
        get {
            return Current;
        }
    }

    public double Current {
        get {
            try {
                return _data[position];
            }
            catch (IndexOutOfRangeException) {
                throw new InvalidOperationException();
            }
        }
    }
}