using NanoidDotNet;
using System.Security.Cryptography;
using UniqueIdGenerator.Contacts;

namespace UniqueIdGenerator.Services
{
    public class NanoIDService : INanoIDService
    {

        public NanoIDService()
        {

        }

        public string GetNanoIDValue()
        {
            // Generate a unique ID with default length (21)
            string uniqueId = Nanoid.Generate();
            Console.WriteLine($"Generated Unique ID: {uniqueId}");

            return uniqueId.ToString();
        }

        public string GetNanoIDAlphabateValue()
        {

            // Generate a unique ID with Alphabate 
            string uniqueId = Nanoid.Generate(Nanoid.Alphabets.Default);
            Console.WriteLine($"Generated Unique ID: {uniqueId}");

            return uniqueId.ToString();
        }
    }
}
