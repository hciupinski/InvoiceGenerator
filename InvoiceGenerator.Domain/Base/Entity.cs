namespace InvoiceGenerator.Domain.Base;

public class Entity : IEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}