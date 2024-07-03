using System.IO.Compression;

namespace _03_StreamDecorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // StreamDecorator is a class that inherits from Stream and has a Stream object as a field
            // It has a constructor that takes a Stream object as a parameter and assigns it to the field
            // It overrides all the methods of Stream and calls the corresponding methods of the field
            // It can also add some additional functionality to the methods of Stream
            // StreamDecorator is used to add some additional functionality to the methods of Stream without changing the Stream class itself

            // DeflateStream is a class that inherits from Stream and has a Stream object as a field
            // It has a constructor that takes a Stream object as a parameter and assigns it to the field
            // It overrides all the methods of Stream and calls the corresponding methods of the field
            // It can also add some additional functionality to the methods of Stream
            // DeflateStream is used to compress the data that is written to the stream and decompress the data that is read from the stream
            // DeflateStream is a StreamDecorator
            // DeflateStream has constructors:
            // 1. DeflateStream(Stream stream, CompressionMode mode)
            // 2. DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
            // 3. DeflateStream(Stream stream, CompressionLevel compressionLevel)
            // 4. DeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen)
            // 5. DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, bool gzip)
            // 6. DeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen, bool gzip)

            // DeflateStream has a property:
            // 1. BaseStream: Gets the underlying stream

            // DeflateStream has methods:
            // 1. Flush: Flushes the contents of the internal buffer of the stream
            // 2. Read: Reads a sequence of bytes from the stream and advances the position within the stream by the number of bytes read
            // 3. Write: Writes a sequence of bytes to the stream and advances the current position within this stream by the number of bytes written
            // 4. BeginRead: Begins an asynchronous read operation
            // 5. BeginWrite: Begins an asynchronous write operation
            // 6. CopyTo: Reads the bytes from the current stream and writes them to another stream
            // 7. Dispose: Releases the unmanaged resources used by the DeflateStream and optionally releases the managed resources
            // 8. EndRead: Ends an asynchronous read operation
            // 9. EndWrite: Ends an asynchronous write operation
            // 10. Seek: Sets the position within the current stream
            // 11. SetLength: Sets the length of the current stream
            // 12. ToString: Returns a string that represents the current object
            // 13. WriteAsync: Asynchronously writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written
            // 14. ReadAsync: Asynchronously reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read
            // 15. DisposeAsync: Asynchronously releases the unmanaged resources used by the DeflateStream
            // 16. CopyToAsync: Asynchronously reads the bytes from the current stream and writes them to another stream
            // 17. ReadByte: Reads a byte from the stream and advances the position within the stream by one byte, or returns -1 if at the end of the stream
            // 18. WriteByte: Writes a byte to the current position in the stream and advances the position within the stream by one byte
            // 19. WriteTo: Writes the contents of the stream to another stream
            // 20. ReadSpan: Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read
            // 21. WriteSpan: Writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written
            // 



            using (var stream = File.Create("data.bin"))            // Create a file stream
            {
                using (var deflateStram = new DeflateStream(stream, CompressionMode.Compress))  // Create a DeflateStream object that compresses the data that is written to the stream 
                {
                    deflateStram.WriteByte(65);
                    deflateStram.WriteByte(66);
                }
            }

            using (var stream = File.OpenRead("data.bin"))            // Open a file stream
            {
                using (var deflateStream = new DeflateStream(stream, CompressionMode.Decompress))  // Create a DeflateStream object that decompresses the data that is read from the stream 
                {
                    var b1 = deflateStream.ReadByte();
                    Console.WriteLine(b1);
                    var b2 = deflateStream.ReadByte();
                    Console.WriteLine(b2);
                }
            }

        }
    }
}
