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
    public class RemoveCategoryCommadHandler
    {
        private readonly IRepository<Category> _repository;
        public RemoveCategoryCommadHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCategoryCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }
    }
}
