namespace StarFitApi.Models.Exception;

public class NotFoundException : System.Exception
{
    public NotFoundException(string message) : base(message)
    {
    }
}