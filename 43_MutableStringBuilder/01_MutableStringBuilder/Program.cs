using System.Text;

namespace _01_MutableStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String is immutable in C#
            // StringBuilder is mutable in C# 
            // StringBuilder is more efficient than String when we have to perform multiple operations on the string data.
            // StringBuilder is a mutable string, which means it can be modified once it has been created.
            // StringBuilder is a part of System.Text namespace.
            // StringBuilder is a dynamic object that can be used to build strings efficiently.
            // StringBuilder does not create a new object in the memory, whenever you make a change in the string data. It changes the existing object.



        }

        static string GenerateWithString()
        {
            string str = null;

            str += String.Concat(new char[] { 'E', 'T', 'I' }); // ETI

            str += String.Format("GAT{0}{1}{2}", 'O', 'P', 'S'); // GATOPS

            str = "M" + str; // METIGATOPS

            str = str.Replace('P', 'R'); //METIGATORS

            str = str.Remove(str.Length - 1); // METIGATOR 

            return str;
        }
        static string GenerateWithStringBuilder()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(new char[] { 'E', 'T', 'I' }); // ETI

            sb.AppendFormat("GAT{0}{1}{2}", 'O', 'P', 'S'); // ETIGATOPS

            sb.Insert(0, "M"); // METIGATOPS

            sb.Replace('P', 'R'); //METIGATORS

            sb.Remove(sb.Length - 1, 1); // METIGATOR 

            return sb.ToString();
        }
    }
}
