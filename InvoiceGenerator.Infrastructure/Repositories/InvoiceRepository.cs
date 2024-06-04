using InvoiceGenerator.Domain.Models;
using InvoiceGenerator.Infrastructure.DataAccess;

namespace InvoiceGenerator.Infrastructure.Repositories;

public class InvoiceRepository : Repository<Invoice>
{
    public InvoiceRepository(InvoiceGeneratorDbContext context) : base(context)
    {
    }
}