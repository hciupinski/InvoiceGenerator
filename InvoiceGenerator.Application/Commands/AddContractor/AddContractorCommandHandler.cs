using MediatR;

namespace InvoiceGenerator.Application.Commands.AddContractor;

public class AddContractorCommandHandler : IRequestHandler<AddContractorCommand, Guid>
{
    public Task<Guid> Handle(AddContractorCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}