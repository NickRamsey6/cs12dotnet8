namespace Packt.Shared;

public class PersonException : Exception
{
    // these three are constructors
    public PersonException() : base() { }

    public PersonException(string message) : base(message) { }

    public PersonException(string message, Exception innerException) : base(message, innerException) { }

}