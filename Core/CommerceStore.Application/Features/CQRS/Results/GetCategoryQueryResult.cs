using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceStore.Application.Features.CQRS.Results
{
    public class GetCategoryQueryResult
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
