
using API.Features.ContaFeatures.Commands;
using API.Features.ContaFeatures.Handles;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace APi.Testes
{
    public class ContaTest
    {
        readonly Mock<IMediator> _mediatorMock;
        readonly Mock<INotificationHandler<INotification>> _notificationHandlerMock;
        readonly List<INotification> _notifications;


        [Fact]
        public void SalvarConta()
        {
            //var saveAccountHandler = new CreateAccountCommandHandle(_mediatorMock.Object);

            //var realizarPedidoRequest = new CreateAccountCommand()
            //{
            //    Name = "Teste pedido",
            //    Value = 66.89M,
            //    PaymentDate = new DateTime(2020, 11, 5),
            //    ExpirationDate = new DateTime(2020,10,25)
            //};

            //var result = saveAccountHandler.Handle(realizarPedidoRequest, default);

            //_notifications.Should().ContainItemsAssignableTo<PedidoRealizadoEvent>();

        }
    }
}
