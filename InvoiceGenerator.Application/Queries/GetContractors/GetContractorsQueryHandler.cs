using InvoiceGenerator.Domain.Models;
using MediatR;

namespace InvoiceGenerator.Application.Queries.GetContractors;

public class GetContractorsQueryHandler : IRequestHandler<GetContractorsQuery, List<Contractor>>
{
    public Task<List<Contractor>> Handle(GetContractorsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}