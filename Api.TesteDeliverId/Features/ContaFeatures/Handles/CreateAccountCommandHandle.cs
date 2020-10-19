using Api.TesteDeliverId.Context;
using API.Features.ContaFeatures.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace API.Features.ContaFeatures.Handles
{
    public class CreateAccountCommandHandle : IRequestHandler<CreateAccountCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateAccountCommandHandle(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var command = request.Command();

            _context.Accounts.Add(command);
            await _context.SaveChangesAsync();

            return command.AccountId;
        }
    }
}
