using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceStore.Application.Features.CQRS.Commands
{
    public class RemoveCategoryCommand
    {
        public int Id { get; set; }
        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
