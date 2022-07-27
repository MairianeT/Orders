using AutoMapper;
using Orders.BLL.Data;
using Orders.BLL.Results;
using Orders.Common.Models;
using Orders.Web.Dto;

namespace Orders.Web;

public class AutomapperProfile : Profile
{
    public AutomapperProfile()
    { 
        CreateMap<OrderDto, OrderData>();
        CreateMap<Order, OrderResult>()
            .ForMember(res => res.PickupYear, 
                opt => 
                    opt.MapFrom(ord => ord.PickupDate.Year))
            .ForMember(res => res.PickupMonth, 
                opt => 
                    opt.MapFrom(ord => ord.PickupDate.Month))
            .ForMember(res => res.PickupDay, 
                opt => 
                    opt.MapFrom(ord => ord.PickupDate.Day));
    }
}