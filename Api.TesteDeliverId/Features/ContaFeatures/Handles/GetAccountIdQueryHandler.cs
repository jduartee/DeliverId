using Api.TesteDeliverId.Context;
using Api.TesteDeliverId.Models;
using API.Features.ContaFeatures.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace API.Features.ContaFeatures.Handles
{
    public class GetAccountIdQueryHandler : IRequestHandler<GetAccountByIdQuery, Account>
    {
        private readonly IApplicationDbContext _context;
        public GetAccountIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Account> Handle(GetAccountByIdQuery query, CancellationToken cancellationToken)
        {
            var product = await _context.Accounts.Where(a => a.AccountId == query.Id).FirstOrDefaultAsync();
            if (product == null) return null;
            return product;
        }
    }
}
