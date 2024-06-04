using InvoiceGenerator.Domain.Base;

namespace InvoiceGenerator.Domain.Models;

public class Settings : Entity
{
    public string Language { get; set; }
    public string InvoiceNumberFormat { get; set; }
    public Contractor Owner { get; set; }
}