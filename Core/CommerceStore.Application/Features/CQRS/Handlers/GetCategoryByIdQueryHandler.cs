using CommerceStore.Application.Features.CQRS.Queries;
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
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(int id)
        {
            var values = await _repository.GetById(id);
            return new GetCategoryByIdQueryResult
            {
                CategoryName = values.CategoryName
            };
        }
    }
}
