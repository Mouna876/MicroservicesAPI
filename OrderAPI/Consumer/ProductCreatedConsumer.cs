using MassTransit;
using Models;
using OrderAPI.Data;
using Shared.Models;

namespace OrdersAPI.Consumer
{
    public class ProductCreatedConsumer : IConsumer<ProductCreated>
    {
        private readonly OrderAPIContext _OrdersAPIContext;

        public ProductCreatedConsumer(OrderAPIContext ordersAPIContext)
        {
            _OrdersAPIContext = ordersAPIContext;
        }

        public async Task Consume(ConsumeContext<ProductCreated> context)
        {
            var newProduct = new Product
            {
                // Id = context.Message.Id,
                Name = context.Message.Name
            };

            _OrdersAPIContext.Add(newProduct);
            await _OrdersAPIContext.SaveChangesAsync();
        }
    }
}