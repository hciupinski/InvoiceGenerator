using InvoiceGenerator.Domain.Models;
using MediatR;

namespace InvoiceGenerator.Application.Queries.GetInvoices;

public class GetInvoiceQueryHandler : IRequestHandler<GetInvoicesQuery, List<Invoice>>
{
    public Task<List<Invoice>> Handle(GetInvoicesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}