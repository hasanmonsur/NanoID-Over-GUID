using System.Security.Cryptography;
using UniqueIdGenerator.Contacts;
using XidNet;

namespace UniqueIdGenerator.Services
{
    public class XIdService : IXIdService
    {

        public XIdService()
        {

        }

        public string GetXIdValue()
        {
            var newXid = Xid.NewXid();
            Console.WriteLine($"New Xid: {newXid}");

            return newXid.ToString();
        }

        public string GetXIdValue(string guId)
        {

            Xid parsedXid;
            // Using Guid.Parse
            parsedXid = Xid.Parse(guId);
            Console.WriteLine($"Parsed Xid: {parsedXid}");

            return parsedXid.ToString();
        }
    }
}
