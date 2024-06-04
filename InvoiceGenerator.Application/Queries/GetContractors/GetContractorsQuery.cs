using InvoiceGenerator.Domain.Models;
using MediatR;

namespace InvoiceGenerator.Application.Queries.GetContractors;

public record GetContractorsQuery : IRequest<List<Contractor>>
{
    
}