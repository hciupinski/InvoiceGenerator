using InvoiceGenerator.Domain.Models;
using InvoiceGenerator.Infrastructure.DataAccess;

namespace InvoiceGenerator.Infrastructure.Repositories;

public class ContractorRepository : Repository<Contractor>
{
    public ContractorRepository(InvoiceGeneratorDbContext context) : base(context)
    {
    }
}