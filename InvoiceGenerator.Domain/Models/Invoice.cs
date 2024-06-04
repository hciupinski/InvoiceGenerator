using InvoiceGenerator.Domain.Base;

namespace InvoiceGenerator.Domain.Models;

public class Invoice : Entity
{
    private List<LineItem> _items { get; set; } = new();

    public string Title { get; set; }
    public string InvoiceNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }
    public virtual Contractor Seller { get; set; }
    public Guid SellerId { get; set; }
    public Contractor Customer { get; set; }
    public Guid CustomerId { get; set; }

    public IReadOnlyList<LineItem> Items => _items;
    public string Comments { get; set; }

    private Invoice()
    {
    }

    public Invoice(string title, string invoiceNumber, DateTime issueDate, DateTime dueDate,
        string comments)
    {
        Title = title;
        InvoiceNumber = invoiceNumber;
        IssueDate = issueDate;
        DueDate = dueDate;
        Comments = comments;
    }

    public Invoice AddSeller(Contractor seller)
    {
        Seller = seller;
        return this;
    }

    public Invoice AddCustomer(Contractor customer)
    {
        Customer = customer;
        return this;
    }

    public Invoice AddLineItem(LineItem lineItem)
    {
        _items.Add(lineItem);
        return this;
    }
}