using System.Collections;

public class DataReaderEnum : IEnumerator {
    protected int position;
    protected double[] _data;

    public DataReaderEnum(double[] data) {
        position = -1;
        _data = data;
    }

    public bool IEnumerator.MoveNext() {
        position++;
        return (position < _data.Length);
    }

    public void IEnumerator.Reset() {
        position = -1;
    }

    public Person Current {
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