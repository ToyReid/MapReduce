// Toy Reid
// CS365 - Lab 4
// 03/07/2018

using System;
using System.IO;
using System.Collections;

public class DataReader : IEnumerable {
    protected double[] doublesArray;

    public DataReader(string fileName) {
        // File not found
        if(!File.Exists(fileName)) throw new FileNotFoundException();

        using(BinaryReader b = new BinaryReader(File.OpenRead(fileName))) {
            int position = 0;
            int length = (int)b.BaseStream.Length;
            int size = sizeof(double);

            // No data in file
            if(length == 0) throw new EndOfStreamException();

            // Create array of appropriate length
            doublesArray = new double[length / size];

            // Loop through file, add content to array
            while(position < length) {
                doublesArray[position / size] = b.ReadDouble();
                position += size;
            }
        }
    }

    public int Count {
        get {
            return doublesArray.Length;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
       return (IEnumerator) GetEnumerator();
    }

    public DataReaderEnum GetEnumerator() {
        return new DataReaderEnum(doublesArray);
    }

    // Indexer
    public double this[int i] {
        get {
            if(i >= Count) throw new IndexOutOfRangeException();
            return doublesArray[i];
        }
    }
}