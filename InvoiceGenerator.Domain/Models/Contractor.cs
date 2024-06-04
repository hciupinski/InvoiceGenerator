using InvoiceGenerator.Domain.Base;

namespace InvoiceGenerator.Domain.Models;

public class Contractor : Entity
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string PostalCode { get; private set; }
    public string CompanyName { get; private set; }
    public string Identifier { get; private set; }

    private Contractor(string street, string city, string postalCode)
    {
        Street = street;
        City = city;
        PostalCode = postalCode;
    }

    public Contractor(string companyName, string identifier, string street, string city,
        string postalCode)
    {
        CompanyName = companyName;
        Identifier = identifier;
        Street = street;
        City = city;
        PostalCode = postalCode;
    }

    public Contractor Update(string companyName, string identifier, string street, string city, string postalCode)
    {
        CompanyName = companyName;
        Identifier = identifier;
        Street = street;
        City = city;
        PostalCode = postalCode;
        return this;
    }
}