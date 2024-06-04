using MediatR;

namespace InvoiceGenerator.Application.Commands.UpdateInvoice;

public class UpdateInvoiceCommandHandler : IRequestHandler<UpdateInvoiceCommand>
{
    public Task Handle(UpdateInvoiceCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}