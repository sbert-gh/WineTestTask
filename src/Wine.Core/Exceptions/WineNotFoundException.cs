namespace WineCatalog.Core.Exceptions;

public class WineNotFoundException : Exception
{
    public WineNotFoundException()
        : base("Wine not found.")
    {

    }
}
