using MediatR;

namespace InvoiceGenerator.Application.Commands.AddInvoice;

public class AddInvoiceCommandHandler : IRequestHandler<AddInvoiceCommand, Guid>
{
    public Task<Guid> Handle(AddInvoiceCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}