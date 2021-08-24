using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoryListWithEvents
{
    public class GetCategoriesListWithEventsQuery : IRequest<List<CategoryEventListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}
