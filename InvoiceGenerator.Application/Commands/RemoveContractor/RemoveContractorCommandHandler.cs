using MediatR;

namespace InvoiceGenerator.Application.Commands.RemoveContractor;

public class RemoveContractorCommandHandler : IRequestHandler<RemoveContractorCommand>
{
    public Task Handle(RemoveContractorCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}