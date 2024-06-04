using MediatR;

namespace InvoiceGenerator.Application.Commands.PublishInvoice;

public class PublishInvoiceCommandHandler : IRequestHandler<PublishInvoiceCommand>
{
    public Task Handle(PublishInvoiceCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}