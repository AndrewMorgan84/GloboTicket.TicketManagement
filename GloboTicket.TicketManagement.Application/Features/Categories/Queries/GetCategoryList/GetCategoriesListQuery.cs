using MediatR;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoryList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
    {
    }
}
