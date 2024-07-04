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
    public class GetProductQueryHandler
    {
        private readonly IRepository<Product> _repository;
        public GetProductQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetProductQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetProductQueryResult
            {
                CategoryId = x.CategoryId,
                Price = x.Price,
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                Stock = x.Stock
            }).ToList();
        }
    }
}
