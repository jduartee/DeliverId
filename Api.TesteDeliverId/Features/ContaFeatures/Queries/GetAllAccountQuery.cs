using Api.TesteDeliverId.Models;
using MediatR;
using System.Collections.Generic;

namespace API.Features.ContaFeatures.Queries
{
    public class GetAllAccountQuery : IRequest<IEnumerable<Account>>
    {

    }
}
