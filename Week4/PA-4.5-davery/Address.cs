//Defining Class for address attributes.
public class Address
{
    public int ID { get; set; }
    public string Street_Address1 { get; set; }
    public string Street_Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip_Code { get; set; }

    public Address() { }

    public Address(string street_Address1, string street_Address2, string city, string state, string zip_Code)
    {
        Street_Address1 = street_Address1;
        Street_Address2 = street_Address2;
        City = city;
        State = state;
        Zip_Code = zip_Code;
    }
}