using Api.TesteDeliverId.Context;
using API.Features.ContaFeatures.Queries;
using Api.TesteDeliverId.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace API.Features.ContaFeatures.Handles
{

    public class GetAllAccountQueryHandler : IRequestHandler<GetAllAccountQuery, IEnumerable<Account>>
    {
        private readonly IApplicationDbContext _context;
        public GetAllAccountQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Account>> Handle(GetAllAccountQuery query, CancellationToken cancellationToken)
        {
            var productList = await _context.Accounts.ToListAsync();
            if (productList == null)
            {
                return null;
            }
            return productList.AsReadOnly();
        }
    }

}
