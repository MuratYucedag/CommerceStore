using CommerceStore.Application.Features.CQRS.Commands;
using CommerceStore.Application.Interfaces;
using CommerceStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceStore.Application.Features.CQRS.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly IRepository<Product> _repository;
        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateProductCommand createProductCommand)
        {
            await _repository.CreateAsync(new Product
            {
                ProductName = createProductCommand.ProductName,
                CategoryId = createProductCommand.CategoryId,
                Price = createProductCommand.Price,
                Stock = createProductCommand.Stock
            });
        }
    }
}
