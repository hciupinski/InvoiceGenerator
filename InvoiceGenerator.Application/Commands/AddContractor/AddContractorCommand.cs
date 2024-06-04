using MediatR;

namespace InvoiceGenerator.Application.Commands.AddContractor;

public record AddContractorCommand : IRequest<Guid>
{
    
}