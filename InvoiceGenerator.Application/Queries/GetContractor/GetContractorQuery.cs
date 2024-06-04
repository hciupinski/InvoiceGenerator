using InvoiceGenerator.Domain.Models;
using MediatR;

namespace InvoiceGenerator.Application.Queries.GetContractor;

public record GetContractorQuery : IRequest<Contractor>
{
    
}