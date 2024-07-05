
using System.Xml;
using System.Xml.Serialization;

namespace _01_XMLSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Serialization is the process of converting an object into a stream of bytes to store the object or transmit it to memory, a database, or a file.
            // Deserialization is the process of converting a stream of bytes back into an object.

            // XML Serialization is the process of converting an object into XML format.
            // XML Deserialization is the process of converting XML format back into an object.

            // XmlSerializer class is used to serialize and deserialize an object into an XML format.
            // XmlSerializer class is present in System.Xml.Serialization namespace.
            // XmlSerializer class is used to serialize an object to XML format and deserialize it back to the original object.

            // XmlSerializer class has the following constructors:
            // XmlSerializer(Type type) : Initializes a new instance of the XmlSerializer class that can serialize objects of the specified type into XML document.
            // XmlSerializer(Type type, string defaultNamespace) : Initializes a new instance of the XmlSerializer class that can serialize objects of the specified type into XML document and specifies the default namespace for all the XML elements.

            // XmlSerializer class has the following methods:
            // Serialize(Stream stream, object o) : Serializes the specified object and writes the XML document to a file using the specified Stream.
            // Deserialize(Stream stream) : Deserializes the XML document contained by the specified Stream.
            // Serialize(TextWriter textWriter, object o) : Serializes the specified object and writes the XML document to a file using the specified TextWriter.
            // Deserialize(TextReader textReader) : Deserializes the XML document contained by the specified TextReader.
            // Serialize(XmlWriter xmlWriter, object o) : Serializes the specified object and writes the XML document to a file using the specified XmlWriter.
            // Deserialize(XmlReader xmlReader) : Deserializes the XML document contained by the specified XmlReader.
            // Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) : Serializes the specified object and writes the XML document to a file using the specified XmlWriter and XmlSerializerNamespaces.

            // XmlSerializer class has the following properties:
            // UnknownNode : Gets or sets the method that handles unknown nodes.
            // UnknownAttribute : Gets or sets the method that handles unknown attributes.
            // UnknownElement : Gets or sets the method that handles unknown elements.


            // StringWriter class is used to writing information to a string.
            // It doesn't create another object in memory, it writes directly to the string.
            // StringWriter class is derived from TextWriter class.
            // It uses StringBuilder internally to store the information.
            // StringWriter class is present in System.IO namespace.
            // StringWriter class has the following constructors:
            // StringWriter() : Initializes a new instance of the StringWriter class.
            // StringWriter(IFormatProvider formatProvider) : Initializes a new instance of the StringWriter class that writes to the specified format provider.
            // StringWriter(StringBuilder sb) : Initializes a new instance of the StringWriter class that writes to the specified StringBuilder.

            // StringWriter class has the following methods:
            // Close() : Closes the current StringWriter and the underlying stream.
            // Flush() : Clears all buffers for the current writer and causes any buffered data to be written to the underlying device.
            // Write(char value) : Writes a character to the current StringWriter.
            // Write(string value) : Writes a string to the current StringWriter.
            // Write(char[] buffer, int index, int count) : Writes a subarray of characters to the current StringWriter.
            // WriteAsync(char value) : Writes a character to the current StringWriter asynchronously.
            // WriteAsync(char[] buffer, int index, int count) : Writes a subarray of characters to the current StringWriter asynchronously.
            // WriteAsync(string value) : Writes a string to the current StringWriter asynchronously.
            // WriteLine() : Writes a line terminator to the current StringWriter.
            // WriteLine(char value) : Writes a character followed by a line terminator to the current StringWriter.
            // WriteLine(char[] buffer, int index, int count) : Writes a subarray of characters followed by a line terminator to the current StringWriter.
            // WriteLine(string value) : Writes a string followed by a line terminator to the current StringWriter.
            // WriteLineAsync() : Writes a line terminator to the current StringWriter asynchronously.
            // WriteLineAsync(char value) : Writes a character followed by a line terminator to the current StringWriter asynchronously.
            // WriteLineAsync(char[] buffer, int index, int count) : Writes a subarray of characters followed by a line terminator to the current StringWriter asynchronously.
            // WriteLineAsync(string value) : Writes a string followed by a line terminator to the current StringWriter asynchronously.

            // StringWriter class has the following properties:
            // Encoding : Gets the Encoding in which the output is written.
            // FormatProvider : Gets an object that controls formatting.
            // NewLine : Gets or sets the line terminator string used by the current TextWriter.



            // XmlWriter class represent a writer that provides a fast, non-cached, forward-only way of generating streams or files containing XML data.
            // XmlWriter class is present in System.Xml namespace.
            // XmlWriter class is an abstract class.

            // XmlWriter class has the following methods: 
            // Create(Stream output) : Creates an XmlWriter that writes to a Stream.
            // Create(TextWriter output) : Creates an XmlWriter that writes to a TextWriter.
            // Create(StringBuilder output) : Creates an XmlWriter that writes to a StringBuilder.
            // Create(XmlWriter output) : Creates an XmlWriter that writes to another XmlWriter.
            // Create(Stream output, XmlWriterSettings settings) : Creates an XmlWriter that writes to a Stream with the specified XmlWriterSettings.
            // Create(TextWriter output, XmlWriterSettings settings) : Creates an XmlWriter that writes to a TextWriter with the specified XmlWriterSettings.
            // Create(StringBuilder output, XmlWriterSettings settings) : Creates an XmlWriter that writes to a StringBuilder with the specified XmlWriterSettings.
            // Create(XmlWriter output, XmlWriterSettings settings) : Creates an XmlWriter that writes to another XmlWriter with the specified XmlWriterSettings.


            // TextReader class is the abstract base class of StreamReader and StringReader classes.
            // TextReader class is present in System.IO namespace.
            // TextReader class is used to read characters from a byte stream in a particular encoding.
            // TextReader class has the following methods:
            // Close() : Closes the TextReader and releases any system resources associated with the TextReader.
            // Dispose() : Releases all resources used by the TextReader.
            // Peek() : Reads the next character without changing the state of the reader or the character source.
            // Read() : Reads the next character from the input stream and advances the character position by one character.
            // ReadAsync(char[] buffer, int index, int count) : Reads a specified maximum number of characters from the current reader asynchronously and writes the data to a buffer, beginning at the specified index.
            // ReadBlock(char[] buffer, int index, int count) : Reads a specified maximum number of characters from the current reader and writes the data to a buffer, beginning at the specified index.
            // ReadLine() : Reads a line of characters from the current stream and returns the data as a string.
            // ReadToEnd() : Reads all characters from the current position to the end of the TextReader and returns them as one string.

            // StringReader class is used to read characters from a string.
            // StringReader class is derived from TextReader class.
            // StringReader class is present in System.IO namespace.
            // StringReader class has the following constructors:
            // StringReader(string s) : Initializes a new instance of the StringReader class that reads from the specified string.
            // StringReader(string s, IFormatProvider formatProvider) : Initializes a new instance of the StringReader class that reads from the specified string and writes to the specified format provider.

            // StringReader class has the following methods:
            // Close() : Closes the StringReader and releases any system resources associated with the StringReader.
            // Dispose() : Releases all resources used by the StringReader.
            // Peek() : Reads the next character without changing the state of the reader or the character source.
            // Read() : Reads the next character from the input stream and advances the character position by one character.
            // ReadAsync(char[] buffer, int index, int count) : Reads a specified maximum number of characters from the current reader asynchronously and writes the data to a buffer, beginning at the specified index.
            // ReadBlock(char[] buffer, int index, int count) : Reads a specified maximum number of characters from the current reader and writes the data to a buffer, beginning at the specified index.
            // ReadLine() : Reads a line of characters from the current stream and returns the data as a string.
            // ReadToEnd() : Reads all characters from the current position to the end of the StringReader and returns them as one string.



            // -------------------------------------------------------------------------------------------

            var e1 = new Employee
            {
                Id = 1001,
                Fname = "Issam",
                Lname = "A.",
                Benefits = { "Pension", "Health Insurance" }
            };

            var xmlContent = SerializeToXmlString(e1);

            Console.WriteLine(xmlContent);

            File.WriteAllText("Employee.xml", xmlContent);

            var xmlContentFromFile = File.ReadAllText("Employee.xml");
            Employee employee = DeserializeFromXmlString(xmlContentFromFile);

            Console.ReadKey();
        }

        private static Employee DeserializeFromXmlString(string xmlContentFromFile)
        {
            Employee employee = null;

            // Create an instance of the XmlSerializer class to deserialize the object.
            var xmlSerializer = new XmlSerializer(typeof(Employee));

            // Create an instance of the StringReader class to read the serialized XML string.
            using (var stringReader = new StringReader(xmlContentFromFile))
            {
                // Deserialize the XML string to object.
                employee = xmlSerializer.Deserialize(stringReader) as Employee;
            }

            return employee;
        }

        private static string SerializeToXmlString(Employee e1)
        {
            string result = "";

            // Create an instance of the XmlSerializer class to serialize the object.
            var xmlSerializer = new XmlSerializer(e1.GetType());

            // Create an instance of the StringWriter class to write the serialized XML string.
            using (var stringWriter = new StringWriter())
            {
                // Create an instance of the XmlWriter class to write the serialized XML string.
                using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
                {
                    // Serialize the object to XML string.
                    xmlSerializer.Serialize(xmlWriter, e1);

                    // Get the serialized XML string.
                    result = stringWriter.ToString();
                }
            }

            return result;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public List<string> Benefits { get; set; } = new List<string>();
    }
}
