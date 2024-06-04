using InvoiceGenerator.Domain.Models;
using MediatR;

namespace InvoiceGenerator.Application.Queries.GetInvoices;

public record GetInvoicesQuery : IRequest<List<Invoice>>
{
    
}