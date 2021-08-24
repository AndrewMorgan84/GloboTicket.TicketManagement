using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoryList;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoryListWithEvents;
using GloboTicket.TicketManagement.Application.Features.Events;
using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
        }
    }
}
