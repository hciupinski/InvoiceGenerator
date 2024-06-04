using System.ComponentModel.DataAnnotations;

namespace InvoiceGenerator.API.ViewModels;

public class LineItemViewModel
{
    public Guid Id { get; set; }

    [Required] public string Name { get; set; }

    [Required] public string Unit { get; set; }

    [Required] public decimal Price { get; set; }

    public decimal Net => Price * Quantity;
    public decimal Tax => Net * TaxRate;

    [Required] public decimal TaxRate { get; set; }

    public decimal Gross => Net + Tax;

    [Required] public int Quantity { get; set; }
}