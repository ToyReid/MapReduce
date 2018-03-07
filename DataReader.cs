using System.IO;
using System.Collections;

public class DataReader : IEnumerable {
    protected double[] doublesArray; // RENAME

    public DataReader(string fileName) {
        try {
            // File not found
            if(!File.Exists(fileName)) throw new FileNotFoundException();

            using(BinaryReader b = new BinaryReader(File.OpenRead(fileName))) {
                int position = 0;
                int length = (int)b.BaseStream.Length;
                int size = sizeof(double);

                // No data in file
                if(length == 0) throw new EndOfStreamException();

                // Create array of appropriate length
                doublesArray = new double[length];

                // Loop through file, add content to array
                while(position < length) {
                    doublesArray[position / size] = b.ReadDouble();
                    size += sizeof(double);
                }
            }
        }
        catch(FileNotFoundException) {
            Console.WriteLine("File not found.");
        }
        catch(EndOfStreamException) {
            Console.WriteLine("No doubles to read.");
        }
    }

    public int Count {
        get {
            return doublesArray.Length;
        }
    }

    public DataReaderEnum GetEnumerator() {
        return new DataReaderEnum(doublesArray);
    }
}