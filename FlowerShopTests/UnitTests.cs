using NUnit.Framework;
using FlowerShop;
using NSubstitute;
namespace Tests
{
    public class Tests
    {

        [Test]
        public void OrderDeliver_Deliver_CallSetDelivered()
        {
            //ARRANGE
            var IOrderMock=Substitute.For<IOrderDAO>();
            var IClientMock=Substitute.For<IClient>();
            var orderMock= new Order(IOrderMock,IClientMock); 
            //ACT
            orderMock.Deliver();
            //ASSERT
            IOrderMock.Received().SetDelivered(orderMock);
        }

        [Test]
        public void OrderPrice_Calculates_PriceFlower_Accurately(){
            //ARRANGE
            var IOrderMock=Substitute.For<IOrderDAO>();
            var IClientMock=Substitute.For<IClient>();
            var orderMock= new Order(IOrderMock,IClientMock); 
            //ACT
            //orderMock.Price.Returns(33);
            //ASSERT
            Assert.That(orderMock.Price,Is.EqualTo(33));
        }
    }
}