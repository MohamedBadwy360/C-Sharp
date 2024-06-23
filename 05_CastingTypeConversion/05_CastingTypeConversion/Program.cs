namespace _05_CastingTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Casting and Type Conversion
            // Implicit Casting (automatically) - converting a smaller type to a larger type size
            int myInt = 9;
            double myDouble = myInt; // Automatic casting: int to double
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);

            // Explicit Casting (manually) - converting a larger type to a smaller size type
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2; // Manual casting: double to int => 9 => will lose the decimal part
            Console.WriteLine(myDouble2);
            Console.WriteLine(myInt2);

            // Type Conversion
            // Convert class
            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool = true;
            Console.WriteLine(myBool);
            Console.WriteLine(Convert.ToString(myInt3)); // Convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3)); // Convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3)); // Convert double to int
            Console.WriteLine(Convert.ToString(myBool)); // Convert bool to string

            // Parse
            string myString = "10";
            string myString2 = "10.987";
            string myString3 = "true";
            int myInt4 = int.Parse(myString); // Convert string to int
            double myDouble4 = double.Parse(myString2); // Convert string to double
            bool myBool2 = bool.Parse(myString3); // Convert string to bool
            Console.WriteLine(myInt4);
            Console.WriteLine(myDouble4);
            Console.WriteLine(myBool2);

            // TryParse
            string myString4 = "10";
            string myString5 = "10.987";
            string myString6 = "true";
            int myInt5;
            double myDouble5;
            bool myBool3;
            int.TryParse(myString4, out myInt5); // Convert string to int
            double.TryParse(myString5, out myDouble5); // Convert string to double
            bool.TryParse(myString6, out myBool3); // Convert string to bool
            Console.WriteLine(myInt5);
            Console.WriteLine(myDouble5);
            Console.WriteLine(myBool3);

            // Conversion between different data types
            // int to string
            int myInt6 = 10;
            string myString7 = myInt6.ToString();
            Console.WriteLine(myString7);

            // double to string
            double myDouble6 = 10.987;
            string myString8 = myDouble6.ToString();
            Console.WriteLine(myString8);

            // string to int
            string myString9 = "10";
            int myInt7 = int.Parse(myString9);
            Console.WriteLine(myInt7);

            // string to double
            string myString10 = "10.987";
            double myDouble7 = double.Parse(myString10);
            Console.WriteLine(myDouble7);

            // string to char
            string myString11 = "Hello";
            char myChar = myString11[0];
            Console.WriteLine(myChar);

            // char to string
            char myChar2 = 'X';
            string myString12 = myChar2.ToString();
            Console.WriteLine(myString12);

            // Explicit Conversion
            // int to byte
            int myInt8 = 65;
            byte myByte = (byte)myInt8;
            Console.WriteLine(myByte);

            // double to int
            double myDouble8 = 10.45;
            int myInt9 = (int)myDouble8;
            Console.WriteLine(myInt9);

            // float to int
            float myFloat = 10.45F;
            int myInt10 = (int)myFloat;
            Console.WriteLine(myInt10);

            // byte to int
            byte myByte2 = 65;
            int myInt11 = myByte2;
            Console.WriteLine(myInt11);

            // int to char
            int myInt12 = 65;
            char myChar3 = (char)myInt12;
            Console.WriteLine(myChar3);

            // char to int
            char myChar4 = 'X';
            int myInt13 = myChar4;
            Console.WriteLine(myInt13);

            // string to int
            string myString13 = "123";
            int myInt14 = int.Parse(myString13);
            Console.WriteLine(myInt14);

            // int to string
            int myInt15 = 123;
            string myString14 = myInt15.ToString();
            Console.WriteLine(myString14);

            // int to long
            int myInt16 = 123;
            long myLong = myInt16;
            Console.WriteLine(myLong);

            // long to int
            long myLong2 = 123;
            int myInt17 = (int)myLong2;
            Console.WriteLine(myInt17);

            // float to double
            float myFloat2 = 123.45F;
            double myDouble9 = myFloat2;
            Console.WriteLine(myDouble9);
                
            // double to float
            double myDouble10 = 123.45;
            float myFloat3 = (float)myDouble10;
            Console.WriteLine(myFloat3);

            // float to decimal
            float myFloat4 = 123.45F;
            decimal myDecimal = (decimal)myFloat4;
            Console.WriteLine(myDecimal);

            // decimal to float
            decimal myDecimal2 = 123.45M;
            float myFloat5 = (float)myDecimal2;
            Console.WriteLine(myFloat5);
        }
    }
}
