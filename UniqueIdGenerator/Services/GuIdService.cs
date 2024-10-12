using UniqueIdGenerator.Contacts;

namespace UniqueIdGenerator.Services
{
    public class GuIdService : IGuIdService
    {

        public GuIdService()
        {

        }

        public string GetGuIdValue()
        {
            Guid newGuid = Guid.NewGuid();
            Console.WriteLine($"New GUID: {newGuid}");


            return newGuid.ToString();
        }

        public string GetGuIdValue(string guId)
        {

            Guid parsedGuid;
            // Using Guid.Parse
            parsedGuid = Guid.Parse(guId);
            Console.WriteLine($"Parsed GUID: {parsedGuid}");

            return parsedGuid.ToString();
        }
    }
}
