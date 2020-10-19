using Api.TesteDeliverId.Models;
using MediatR;
using System;

namespace API.Features.ContaFeatures.Commands
{
    public class CreateAccountCommand : IRequest<int>
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime PaymentDate { get; set; }

        public Account Command()
        {
            var conta = new Account { Name = Name, Value = Value, ExpirationDate = ExpirationDate, PaymentDate = PaymentDate };

            var diasAtraso = PaymentDate.Subtract(ExpirationDate).Days;

            if (diasAtraso > 0 && diasAtraso <= 3)
            {
                conta.CurrentValue = conta.Value + (conta.Value * 0.0001M * diasAtraso);
            }
            else if (diasAtraso == 4)
            {
                conta.CurrentValue = conta.Value + (conta.Value * 0.0002M * diasAtraso);
            }
            else if (diasAtraso > 4)
            {
                conta.CurrentValue = conta.Value + (conta.Value * 0.0003M * diasAtraso);
            }
            else
            {
                conta.CurrentValue = conta.Value;
            }

            return conta;
        }
    }
}
