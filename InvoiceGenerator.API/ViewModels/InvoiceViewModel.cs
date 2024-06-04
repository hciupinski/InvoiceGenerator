namespace InvoiceGenerator.API.ViewModels;

public class InvoiceViewModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string InvoiceNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }
    public ContractorViewModel Seller { get; set; }
    public ContractorViewModel Customer { get; set; }

    public List<LineItemViewModel> Items { get; set; } = new();
}