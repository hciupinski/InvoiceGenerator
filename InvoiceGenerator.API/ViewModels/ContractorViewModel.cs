namespace InvoiceGenerator.API.ViewModels;

public class ContractorViewModel
{
    public Guid Id { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string CompanyName { get; set; }
    public string Identifier { get; set; }
}