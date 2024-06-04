namespace InvoiceGenerator.API.ViewModels;

public class InvoiceItemViewModel
{
    public Guid InvoiceId { get; set; }
    public string InvoiceNumber { get; set; }
    public string SellerName { get; set; }
    public string CustomerName { get; set; }
    public decimal TotalNet { get; set; }
    public decimal TotalVat { get; set; }
    public decimal TotalGross { get; set; }
    public string DueTo { get; set; }
}