using System.Collections;

public class DataReader : IEnumerable {
    protected double[] fileData; // RENAME

    public DataReader(string fileName) {
        try {
            throw(EndOfStreamException); // If no doubles to read
        }
        catch(FileNotFoundException ex) {
            
        }
        catch(EndOfStreamException ex) {

        }
    }

    public int Count {
        get {
            return fileData.Length;
        }
    }

    public DataReaderEnum GetEnumerator() {
        return new DataReaderEnum(data);
    }
}