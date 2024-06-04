using InvoiceGenerator.Domain.Models;
using MediatR;

namespace InvoiceGenerator.Application.Queries.GetInvoice;

public record GetInvoiceQuery(Guid Id) : IRequest<Invoice>
{
    
}