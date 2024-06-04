using MediatR;

namespace InvoiceGenerator.Application.Commands.AddInvoice;

public record AddInvoiceCommand : IRequest<Guid>
{
    
}