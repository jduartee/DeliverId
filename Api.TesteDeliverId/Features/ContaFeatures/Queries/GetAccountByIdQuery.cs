using Api.TesteDeliverId.Models;
using MediatR;

namespace API.Features.ContaFeatures.Queries
{
    public class GetAccountByIdQuery : IRequest<Account>
    {
        public int Id { get; set; }

    }
}
