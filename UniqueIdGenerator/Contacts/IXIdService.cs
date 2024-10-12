namespace UniqueIdGenerator.Contacts
{
    public interface IXIdService
    {
        string GetXIdValue();
        string GetXIdValue(string guId);
    }
}