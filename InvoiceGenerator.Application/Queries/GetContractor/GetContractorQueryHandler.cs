using InvoiceGenerator.Domain.Models;
using MediatR;

namespace InvoiceGenerator.Application.Queries.GetContractor;

public class GetContractorQueryHandler : IRequestHandler<GetContractorQuery, Contractor>
{
    public Task<Contractor> Handle(GetContractorQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}