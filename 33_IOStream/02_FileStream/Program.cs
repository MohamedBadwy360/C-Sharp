







namespace _02_FileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Streaming Architecture in .NET Framework is based on the Stream class.
            // Stream class is an abstract class that provides a generic view of a sequence of bytes.
            // A stream is an abstraction of a sequence of bytes, such as a file, an input/output device, an inter-process communication pipe, or a TCP/IP socket.
            // The Stream class and its derived classes provide a generic view of these different types of input and output, and isolate the programmer from the specific details of the operating system and the underlying devices.
            // The Stream class contains methods and properties that are common to all streams.
            // The derived classes provide specific implementations of the Stream class for different types of input and output, such as FileStream, MemoryStream, and NetworkStream.
            // The Stream class also provides a unified model of the classes that allow reading and writing to files and memory, and provides a common base class for all streams.
            // The Stream class is the abstract base class of all streams.
            // There are two types of streams: those that use seekable storage and those that do not.
            // Seekable streams, such as FileStream, support random access to the data, while non-seekable streams, such as NetworkStream, do not.
            // The CanSeek property indicates whether the stream supports seeking.
            // The CanRead and CanWrite properties indicate whether the stream supports reading and writing, respectively.
            // The CanTimeout property indicates whether the stream supports timing out.
            // The ReadTimeout and WriteTimeout properties contain the read and write time-out values, respectively.
            // The BeginRead and BeginWrite methods provide asynchronous read and write operations.
            // The ReadAsync and WriteAsync methods provide Task-based asynchronous read and write operations.
            // The CopyToAsync method provides a way to copy the contents of a stream into another stream asynchronously.
            // The Flush method clears any internal buffers and causes any buffered data to be written to the underlying device.
            // The Close method closes the stream and releases any resources associated with it.
            // The Dispose method calls Close, and also releases any resources used by the Stream.
            // The Length property returns the length of the stream in bytes.
            // The Position property gets or sets the current position within the stream.
            // The Seek method sets the position within the current stream.
            // The SetLength method sets the length of the current stream.
            // The Read method reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.
            // The Write method writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.
            // The ReadByte and WriteByte methods read and write a single byte, respectively.
            // The ReadAsync and WriteAsync methods provide asynchronous read and write operations.
            // The CopyTo method copies the contents of the current stream to another stream.
            // The MemoryStream class creates a stream whose backing store is memory.
            // The FileStream class creates a stream whose backing store is a file.
            // The BufferedStream class provides a wrapper around another stream that adds buffering.
            // The NetworkStream class provides a stream that uses a socket for communication.
            // The PipeStream class provides a stream that uses a pipe for communication.
            // The CryptoStream class provides a stream that uses cryptographic transformations.
            // The GZipStream class provides a stream that uses the GZip data format.
            // The DeflateStream class provides a stream that uses the Deflate data format.
            // The ZipArchive class provides a way to create and manage zip archives.
            // There are species of streams that are used to read and write data in different ways.
            // The BinaryReader and BinaryWriter classes provide methods for reading and writing primitive data types in binary format.
            // The StreamReader and StreamWriter classes provide methods for reading and writing characters in a particular encoding.
            // The StringReader and StringWriter classes provide methods for reading and writing strings.
            // The TextReader and TextWriter classes provide methods for reading and writing characters.


            // Stream Class (Abstract Class) 
            // Back Store Streams (FileStream, MemoryStream, NetworkStream, PipeStream)
            // Decorator Streams (BufferedStream, CryptoStream, GZipStream, DeflateStream)
            // Adapter Streams (StreamReader, StreamWriter)
            // Composite Streams (ZipArchive)
            // Reader/Writer Streams (BinaryReader, BinaryWriter, StreamReader, StreamWriter, StringReader, StringWriter, TextReader, TextWriter)
            // Asynchronous Streams (BeginRead, BeginWrite, ReadAsync, WriteAsync, CopyToAsync)
            // Synchronous Streams (Read, Write, ReadByte, WriteByte, CopyTo)
            // Seekable Streams (CanSeek, Length, Position, Seek, SetLength)
            // Readable Streams (CanRead, Read, ReadByte, ReadAsync)
            // Writable Streams (CanWrite, Write, WriteByte, WriteAsync)
            // Timeout Streams (CanTimeout, ReadTimeout, WriteTimeout)
            // Closeable Streams (Close, Dispose)
            // Flushable Streams (Flush)
            // Copyable Streams (CopyTo)
            // Stream Properties (CanRead, CanSeek, CanTimeout, CanWrite, Length, Position)


            // ---------------------------------------------------------------------------

            // FileStream Class (Derived Class)
            // FileStream deals with byte data.
            // FileStream class is used to read from and write to files.
            // FileStream class is derived from the Stream class.
            // FileStream class provides a Stream for a file.
            // FileStream class provides methods for reading and writing bytes to and from a file.
            // FileStream class provides methods for opening, closing, and deleting files.
            // FileStream has constructors that allow you to open a file in different modes: Read, Write, Append, Create, CreateNew, Open, OpenOrCreate, Truncate.
            // 1. Read: Opens the file for reading.
            // 2. Write: Opens the file for writing.
            // 3. Append: Opens the file for writing and positions the stream at the end of the file.
            // 4. Create: Creates a new file. An exception is thrown if the file already exists.
            // 5. CreateNew: Creates a new file. An exception is thrown if the file already exists.
            // 6. Open: Opens an existing file.
            // 7. OpenOrCreate: Opens an existing file, or creates a new file if it does not exist.
            // 8. Truncate: Opens the file for writing and truncates the file to zero bytes. The stream is positioned at the beginning of the file.

            // FileStream Constructors:
            // 1. FileStream(String, FileMode): Initializes a new instance of the FileStream class for the specified file handle.
            // 2. FileStream(String, FileMode, FileAccess): Initializes a new instance of the FileStream class with the specified file handle, file mode, and file access.
            // 3. FileStream(String, FileMode, FileAccess, FileShare): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, and file share.
            // 4. FileStream(String, FileMode, FileAccess, FileShare, Int32): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, file share, and buffer size.
            // 5. FileStream(String, FileMode, FileAccess, FileShare, Int32, Boolean): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, file share, buffer size, and synchronous I/O flag.
            // 6. FileStream(String, FileMode, FileAccess, FileShare, Int32, FileOptions): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, file share, buffer size, and file options.
            // 7. FileStream(String, FileMode, FileAccess, FileShare, Int32, FileOptions, String): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, file share, buffer size, file options, and file name.
            // 8. FileStream(String, FileMode, FileAccess, FileShare, Int32, Boolean, FileOptions): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, file share, buffer size, useAsync, and file options.
            // 9. FileStream(String, FileMode, FileAccess, FileShare, Int32, Boolean, FileOptions, FileStream): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, file share, buffer size, useAsync, file options, and file stream.
            // 10. FileStream(String, FileMode, FileAccess, FileShare, Int32, Boolean, FileOptions, FileStream, Int64): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, file share, buffer size, useAsync, file options, file stream, and file length.
            // 11. FileStream(String, FileMode, FileAccess, FileShare, Int32, Boolean, FileOptions, FileStream, Int64, Boolean): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, file share, buffer size, useAsync, file options, file stream, file length, and isAsync.
            // 12. FileStream(String, FileMode, FileAccess, FileShare, Int32, Boolean, FileOptions, FileStream, Int64, Boolean, Boolean): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, file share, buffer size, useAsync, file options, file stream, file length, isAsync, and ownsStream.
            // 13. FileStream(String, FileMode, FileAccess, FileShare, Int32, Boolean, FileOptions, FileStream, Int64, Boolean, Boolean, Boolean): Initializes a new instance of the FileStream class with the specified file handle, file mode, file access, file share, buffer size, useAsync, file options, file stream, file length, isAsync, ownsStream, and leaveOpen.
            // 14. FileStream(SafeFileHandle, FileAccess): Initializes a new instance of the FileStream class for the specified file handle with the specified read/write permission.
            // 15. FileStream(SafeFileHandle, FileAccess, Int32): Initializes a new instance of the FileStream class for the specified file handle with the specified read/write permission and buffer size.
            // 16. FileStream(SafeFileHandle, FileAccess, Int32, Boolean): Initializes a new instance of the FileStream class for the specified file handle with the specified read/write permission, buffer size, and synchronous I/O flag.
            // 17. FileStream(SafeFileHandle, FileAccess, Int32, Boolean, Boolean): Initializes a new instance of the FileStream class for the specified file handle with the specified read/write permission, buffer size, synchronous I/O flag, and file ownership.

            // FileStream Properties:
            // 1. CanRead: Gets a value indicating whether the current stream supports reading.
            // 2. CanSeek: Gets a value indicating whether the current stream supports seeking.
            // 3. CanTimeout: Gets a value that determines whether the current stream can time out.
            // 4. CanWrite: Gets a value indicating whether the current stream supports writing.
            // 5. Length: Gets the length in bytes of the stream.
            // 6. Position: Gets or sets the current position of the current stream.

            // FileStream Methods:
            // 1. BeginRead: Begins an asynchronous read operation.
            // 2. BeginWrite: Begins an asynchronous write operation.
            // 3. Close: Closes the current stream and releases any resources (such as sockets and file handles) associated with the current stream.
            // 4. CopyTo: Reads the bytes from the current stream and writes them to another stream.
            // 5. CreateObjRef: Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object.
            // 6. CreateWaitHandle: Allocates a WaitHandle object.
            // 7. Dispose: Releases all resources used by the Stream.
            // 8. EndRead: Ends an asynchronous read operation.
            // 9. EndWrite: Ends an asynchronous write operation.
            // 10. Equals: Determines whether the specified object is equal to the current object.
            // 11. Flush: Clears all buffers for this stream and causes any buffered data to be written to the underlying device.
            // 12. FlushAsync: Asynchronously clears all buffers for this stream and causes any buffered data to be written to the underlying device.
            // 13. WriteByte: Writes a byte to the current position in the stream and advances the position within the stream by one byte.
            // 14. GetAccessControl: Gets a FileSecurity object that encapsulates the access control list (ACL) entries for the file described by the current FileStream object.
            // 15. GetHashCode: Serves as the default hash function.
            // 16. GetLifetimeService: Retrieves the current lifetime service object that controls the lifetime policy for this instance.
            // 17. GetType: Gets the Type of the current instance.
            // 18. InitializeLifetimeService: Obtains a lifetime service object to control the lifetime policy for this instance.
            // 19. MemberwiseClone: Creates a shallow copy of the current Object.
            // 20. ObjectInvariant: Used to ensure that the stream is not closed when an operation is performed on it.
            // 21. Read: Reads a block of bytes from the stream and writes the data in a given buffer.
            // 22. ReadAsync: Asynchronously reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.
            // 23. ReadByte: Reads a byte from the stream and advances the position within the stream by one byte, or returns -1 if at the end of the stream.
            // 24. Seek: Sets the position within the current stream.
            // 25. SetAccessControl: Applies access control list (ACL) entries described by a FileSecurity object to the file described by the current FileStream object.
            // 26. SetLength: Sets the length of the current stream.
            // 27. ToString: Returns a string that represents the current object.
            // 28. Write: Writes a block of bytes to the stream using data from a buffer.
            // 29. WriteAsync: Asynchronously writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.
            // 30. WriteByte: Writes a byte to the current position in the stream and advances the position within the stream by one byte.
            // 31. EndRead: Ends an asynchronous read operation.
            // 32. EndWrite: Ends an asynchronous write operation.



            // FileMode Enumeration:
            // 1. Append: Opens the file if it exists and seeks to the end of the file, or creates a new file.
            // 2. Create: Specifies that the operating system should create a new file. If the file already exists, it will be overwritten.
            // 3. CreateNew: Specifies that the operating system should create a new file. If the file already exists, an IOException is thrown.
            // 4. Open: Specifies that the operating system should open an existing file. The ability to open the file is dependent on the value specified by the FileAccess enumeration.
            // 5. OpenOrCreate: Specifies that the operating system should open a file if it exists; otherwise, a new file should be created.
            // 6. Truncate: Specifies that the operating system should open an existing file. Once opened, the file should be truncated so that its size is zero bytes.

            // FileAccess Enumeration:
            // 1. Read: Read access to the file. Data can be read from the file.
            // 2. Write: Write access to the file. Data can be written to the file.
            // 3. ReadWrite: Read and write access to the file. Data can be written to and read from the file.

            // FileShare Enumeration:
            // 1. None: Declines sharing of the current file. Any request to open the file (by this process or another process) will fail until the file is closed.
            // 2. Read: Allows subsequent opening of the file for reading.
            // 3. Write: Allows subsequent opening of the file for writing.
            // 4. ReadWrite: Allows subsequent opening of the file for reading or writing.

            // FileOptions Enumeration:
            // 1. Asynchronous: Indicates that the file is to be used for asynchronous I/O.
            // 2. DeleteOnClose: Indicates that the file is to be deleted when it is closed.
            // 3. Encrypted: Indicates that the file is encrypted and can be decrypted only by using the same user account used for encryption.
            // 4. None: No additional options are specified.
            // 5. RandomAccess: Indicates that the system should write through any intermediate cache and go directly to disk.
            // 6. SequentialScan: Indicates that the file is to be accessed sequentially from beginning to end.
            // 7. WriteThrough: Indicates that the system should write through any intermediate cache and go directly to disk.

            // --------------------------------------------------------------------------------

            // Using Adapters make it easier to read and write data.
            // Using Decorators make it easier to add functionality to streams.
            // Using Composite Streams make it easier to work with multiple streams.
            // Using Asynchronous Streams make it easier to work with asynchronous I/O.

            // --------------------------------------------------------------------------------

            // Adapter is a wrapper on FileStream that provides additional functionality.
            // Decorator is a wrapper on FileStream that adds functionality.

            // Adapter is a wrapper that changes the interface of an object.
            // Decorator is a wrapper that adds functionality to an object.

            // Adapter allow you to use his functionality and make it easier to work with FileStream.
            // Adaper internally work with FileStream and provide additional functionality.
            // Adapter make it easier to work with FileStream.
            // Types of Adapter: StreamReader, StreamWriter.

            // StreamWriter is an adapter that provides additional functionality to FileStream.
            // StreamWriter is an adapter that changes the interface of FileStream.
            // StreamWriter is an adapter that makes it easier to work with FileStream.
            // StreamWriter is an adapter that internally works with FileStream and provides additional functionality.
            // StreamWriter Has methods: 
            // 1. Write: Writes a string to the stream.
            // 2. WriteLine: Writes a string followed by a line terminator to the stream.
            // 3. Flush: Clears all buffers for the current writer and causes any buffered data to be written to the underlying stream.
            // 4. Close: Closes the current StreamWriter object and the underlying stream.
            // 5. Dispose: Releases all resources used by the StreamWriter object.
            // 6. AutoFlush: Gets or sets a value indicating whether the StreamWriter will flush its buffer to the underlying stream after every call to Write.
            // 7. BaseStream: Gets the underlying stream that interfaces with a backing store.
            // 8. Encoding: Gets the Encoding in which the output is written.
            // 9. NewLine: Gets or sets the line terminator string used by the current TextWriter.
            // 10. WriteAsync: Writes a string to the stream asynchronously.
            // 11. WriteLineAsync: Writes a string followed by a line terminator to the stream asynchronously.

            // --------------------------------------------------------------------------------

            // StreamReader is an adapter that provides additional functionality to FileStream.
            // StreamReader is an adapter that changes the interface of FileStream.
            // StreamReader is an adapter that makes it easier to work with FileStream.
            // StreamReader is an adapter that internally works with FileStream and provides additional functionality.
            // StreamReader Has methods:
            // 1. Read: Reads the next character from the input stream and advances the character position by one character.
            // 2. ReadBlock: Reads a specified maximum number of characters from the current stream and writes the data to a buffer, beginning at the specified index.
            // 3. ReadLine: Reads a line of characters from the current stream and returns the data as a string.
            // 4. ReadToEnd: Reads all characters from the current position to the end of the stream.
            // 5. Close: Closes the StreamReader object and the underlying stream.
            // 6. Dispose: Releases all resources used by the StreamReader object.
            // 7. BaseStream: Gets the underlying stream that interfaces with a backing store.
            // 8. CurrentEncoding: Gets the Encoding in which the input is read.
            // 9. EndOfStream: Gets a value that indicates whether the current stream position is at the end of the stream.
            // 10. Peek: Reads the next character from the input stream without advancing the character position.
            // 11. ReadAsync: Reads the next character from the input stream asynchronously.
            // 12. ReadBlockAsync: Reads a specified maximum number of characters from the current stream asynchronously and writes the data to a buffer, beginning at the specified index.
            // 13. ReadLineAsync: Reads a line of characters from the current stream asynchronously and returns the data as a string.
            // 14. ReadToEndAsync: Reads all characters from the current position to the end of the stream asynchronously.

            // --------------------------------------------------------------------------------

            // File Class
            // File class provides static methods for the creation, copying, deletion, moving, and opening of files.
            // File class provides methods for reading and writing files.
            // File class provides methods for checking the existence of files and directories.
            // File class provides methods for retrieving file attributes.
            // File class provides methods for setting file attributes.
            // File is a static class that provides methods for working with files. 
            // File is implemented with Facade Design Pattern. 
            // File methods are static and can be called directly on the class.
            // Methods of File class:
            // 1. AppendAllLines: Appends lines to a file, and then closes the file. If the specified file does not exist, this method creates a file, writes the specified lines to the file, and then closes the file.
            // 2. AppendAllText: Opens a file, appends the specified string to the file, and then closes the file. If the file does not exist, this method creates a file, writes the specified string to the file, then closes the file.
            // 3. AppendText: Creates a StreamWriter that appends UTF-8 encoded text to an existing file, or to a new file if the specified file does not exist.
            // 4. Copy: Copies an existing file to a new file. Overwriting a file of the same name is not allowed.
            // 5. Create: Creates or overwrites a file in the specified path.
            // 6. CreateText: Creates or opens a file for writing UTF-8 encoded text.
            // 7. Delete: Deletes the specified file.
            // 8. Exists: Determines whether the specified file exists.
            // 9. GetAttributes: Gets the FileAttributes of the file on the path.
            // 10. Move: Moves a specified file to a new location, providing the option to specify a new file name.
            // 11. Open: Opens a FileStream on the specified path with read/write access.
            // 12. ReadAllBytes: Opens a binary file, reads the contents of the file into a byte array, and then closes the file.
            // 13. ReadAllLines: Opens a text file, reads all lines of the file, and then closes the file.
            // 14. ReadAllText: Opens a text file, reads all lines of the file, and then closes the file.
            // 15. ReadLines: Opens a text file, reads all lines of the file, and then closes the file.
            // 16. Replace: Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file.
            // 17. SetAttributes: Sets the specified FileAttributes of the file on the specified path.
            // 18. WriteAllBytes: Creates a new file, writes the specified byte array to the file, and then closes the file. If the target file already exists, it is overwritten.
            // 19. WriteAllLines: Creates a new file, writes a collection of strings to the file, and then closes the file.
            // 20. WriteAllText: Creates a new file, writes the specified string to the file, and then closes the file. If the target file already exists, it is overwritten.
            // 21. WriteLines: Creates a new file, writes a collection of strings to the file, and then closes the file.
            // 22. GetCreationTime: Gets the creation date and time of a file or directory.
            // 23. GetCreationTimeUtc: Gets the creation date and time, in Coordinated Universal Time (UTC) format, of a file or directory.
            // 24. GetLastAccessTime: Gets the date and time the specified file or directory was last accessed.
            // 25. GetLastAccessTimeUtc: Gets the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last accessed.
            // 26. GetLastWriteTime: Gets the date and time when the specified file or directory was last written to.
            // 27. GetLastWriteTimeUtc: Gets the date and time, in Coordinated Universal Time (UTC) format, when the specified file or directory was last written to.
            // 28. SetCreationTime: Sets the date and time the file was created.
            // 29. SetCreationTimeUtc: Sets the date and time, in Coordinated Universal Time (UTC) format, that the file was created.
            // 30. SetLastAccessTime: Sets the date and time the specified file or directory was last accessed.
            // 31. SetLastAccessTimeUtc: Sets the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last accessed.
            // 32. SetLastWriteTime: Sets the date and time when the specified file or directory was last written to.
            // 33. SetLastWriteTimeUtc: Sets the date and time, in Coordinated Universal Time (UTC) format, when the specified file or directory was last written to.




            //Example1();
            //Example2();
            //Example3();
            //Example4();
            //Example5();
            //Example6();
            //Example7();
            //Example8();
            //Example9();
            Example10();


            Console.ReadKey();
        }

        // File Class Example - ReadAllLines
        private static void Example10()
        {
            string path = @"C:\Users\Mohamed Badwy\Desktop\sample4.txt";

            var result = File.ReadAllLines(path);

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }
        }

        // File Class Example - ReadAllText
        private static void Example9()
        {
            string path = @"C:\Users\Mohamed Badwy\Desktop\sample5.txt";

            var result = File.ReadAllText(path);

            Console.WriteLine(result);
        }

        // File Class Example - WriteAllText
        private static void Example8()
        {
            string path = @"C:\Users\Mohamed Badwy\Desktop\sample5.txt";

            string text = "C# is amazing language";

            File.WriteAllText(path, text);
        }

        // File Class Example - WriteAllLines
        private static void Example7()
        {
            string[] lines = new string[]
            {
                "C#",
                "is",
                "amazing",
                "language"
            };

            string path = @"C:\Users\Mohamed Badwy\Desktop\sample5.txt";

            File.WriteAllLines(path, lines);
        }

        // StreamWriter Example
        private static void Example4()
        {
            var path = @"C:\Users\Mohamed Badwy\Desktop\sample4.txt";

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("Hello World!");         // Write Line 
                streamWriter.WriteLine("C#");
                streamWriter.WriteLine("Programming");

                //streamWriter.Write("Hello World!");              // Write
            }
        }

        // StreamReader Example
        private static void Example5()
        {
            var path = @"C:\Users\Mohamed Badwy\Desktop\sample4.txt";

            using (StreamReader streamReader = new StreamReader(path))
            {
                while (!streamReader.EndOfStream)
                {
                    Console.Write((char)streamReader.Read());
                }


                //while (streamReader.Peek() > 0)
                //{
                //    Console.WriteLine((char)streamReader.Read());
                //}
            }
        }

        // StreamReader Example
        private static void Example6()
        {
            var path = @"C:\Users\Mohamed Badwy\Desktop\sample4.txt";

            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                while ((line = streamReader.ReadLine()) is not null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        // ---------------------------------------------------------------------------

        // Traditional Way to Read and Write Data using FileStream



        // FileStream Example
        private static void Example1()
        {
            string path = @"C:\Users\Mohamed Badwy\Desktop\sample.txt";

            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                Console.WriteLine($"Length: {fileStream.Length} Byte(s)");
                Console.WriteLine($"Position: {fileStream.Position}");
                Console.WriteLine($"CanRead: {fileStream.CanRead}");
                Console.WriteLine($"CanSeek: {fileStream.CanSeek}");
                Console.WriteLine($"CanTimeout: {fileStream.CanTimeout}");
                Console.WriteLine($"CanWrite: {fileStream.CanWrite}");

                fileStream.WriteByte(65);                                   // Write Byte (ASCII: A)
                Console.WriteLine($"Position: {fileStream.Position}");      // Position: 1 

                fileStream.WriteByte(66);                                   // Write Byte (ASCII: B)
                Console.WriteLine($"Position: {fileStream.Position}");      // Position: 2

                fileStream.WriteByte(13);                                   // Write Byte (ASCII: Carriage Return)

                for (byte i = 65; i < 123; i++)
                {
                    fileStream.WriteByte(i);                                // Write Byte (ASCII: A-Z, a-z)
                }
            }
        }

        // Buffering Example using FileStream (Read and Write) - traditional way
        // Buffering is a technique used to improve the performance of reading and writing data.
        // BufferedStream class provides a wrapper around another stream that adds buffering.
        // Buffering is the process of storing data in a buffer before it is written to the underlying device.
        // BufferedStream class provides a buffer for reading and writing data.
        private static void Example2()
        {
            string path = @"C:\Users\Mohamed Badwy\Desktop\sample.txt";
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] data = new byte[fileStream.Length];
                int numberOfBytesToRead = (int)fileStream.Length;
                int numberOfBytesRead = 0;

                while (numberOfBytesToRead > 0)
                {
                    // Read the data from the file stream and store it in the data array.
                    int BytesRead = fileStream.Read(data, numberOfBytesRead, numberOfBytesToRead);

                    if (BytesRead == 0)
                    {
                        break;
                    }

                    numberOfBytesToRead -= BytesRead;
                    numberOfBytesRead += BytesRead;
                }

                foreach (byte b in data)
                {
                    Console.WriteLine((char)b);
                }

                // Write the data to another file
                string path2 = @"C:\Users\Mohamed Badwy\Desktop\sample2.txt";
                using (FileStream writeFileStream = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    // Write the data to the file stream.
                    writeFileStream.Write(data, 0, data.Length);
                }
            }
        }


        // Seek Example using FileStream
        // Seek method sets the position within the current stream.
        private static void Example3()
        {
            string path = @"C:\Users\Mohamed Badwy\Desktop\sample3.txt";
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fileStream.Seek(20, SeekOrigin.Begin); // Seek to the 20th byte from the beginning of the file.
                fileStream.WriteByte(65);              // Write Byte (ASCII: A)
                fileStream.Position = 0;

                for (int i = 0; i < fileStream.Length; i++)
                {
                    //Console.WriteLine((char)fileStream.ReadByte());
                    Console.WriteLine(fileStream.ReadByte());
                }
            }
        }
    }
}
