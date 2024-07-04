using CommerceStore.Application.Features.CQRS.Results;
using CommerceStore.Application.Interfaces;
using CommerceStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceStore.Application.Features.CQRS.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly IRepository<Product> _repository;
        public GetProductByIdQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<GetProductByIdQueryResult> Handle(int id)
        {
            var values = await _repository.GetById(id);
            return new GetProductByIdQueryResult
            {
                ProductName = values.ProductName,
                CategoryId = values.CategoryId,
                Price = values.Price,
                ProductId = values.ProductId,
                Stock = values.Stock
            };
        }
    }
}
