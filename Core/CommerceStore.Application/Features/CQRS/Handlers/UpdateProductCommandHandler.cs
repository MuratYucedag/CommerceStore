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
    public class UpdateProductCommandHandler
    {
        private readonly IRepository<Product> _repository;
        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateProductCommand command)
        {
            var value = await _repository.GetById(command.ProductId);
            value.ProductName = command.ProductName;
            value.Price = command.Price;
            value.Stock = command.Stock;
            value.CategoryId = command.CategoryId;
            await _repository.UpdateAsync(value);
        }
    }
}
