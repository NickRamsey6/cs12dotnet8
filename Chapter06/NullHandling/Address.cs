namespace Packt.Shared;

public class Address
{
    // NRT is enabled for Building so that can be nullable
    public string? Building;
    // We set Street to an empty string
    public string Street = string.Empty;
    public string City;
    public string Region;

    public Address()
    {
        // City and Region are also set to empty strings here. But why here in this constructor?
        City = string.Empty;
        Region = string.Empty;
    }

    // Call the default parameterless constructor to ensure that Region is also set
    // I'm not sure why or what's happening here
    public Address(string city) : this()
    {
        City = city;
    }

}
