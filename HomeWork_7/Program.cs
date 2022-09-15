using System;

namespace HomeWork_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalString = "SomeCode";
            Console.WriteLine($"Original string: {originalString}\n");

            Acoder acoder = new();
            string encodedByAcoder = acoder.Encode(originalString);
            Console.WriteLine("Acoder algorithm results:");
            Console.WriteLine($"\tEncoded string: {encodedByAcoder}");
            string decodedByAcoder = acoder.Decode(encodedByAcoder);
            Console.WriteLine($"\tDecoded string: {decodedByAcoder}");
            Console.WriteLine();

            Bcoder bcoder = new();
            string encodedByBcoder = bcoder.Encode(originalString);
            Console.WriteLine("Bcoder algorithm results:");
            Console.WriteLine($"\tEncoded string: {encodedByBcoder}");
            string decodedByBcoder = bcoder.Decode(encodedByBcoder);
            Console.WriteLine($"\tDecoded string: {decodedByBcoder}");
        }
    }
}
