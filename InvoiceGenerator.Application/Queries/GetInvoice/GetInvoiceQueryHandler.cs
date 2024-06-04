using InvoiceGenerator.Domain.Models;
using MediatR;

namespace InvoiceGenerator.Application.Queries.GetInvoice;

public class GetInvoiceQueryHandler : IRequestHandler<GetInvoiceQuery, Invoice>
{
    public Task<Invoice> Handle(GetInvoiceQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}