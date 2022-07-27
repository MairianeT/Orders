using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Orders.BLL.Data;
using Orders.BLL.Orders;
using Orders.BLL.Results;
using Orders.Common;
using Orders.Web.Dto;

namespace Orders.Web.Controllers;
[ApiController]
[Route("/orders")]
public class OrdersController : ControllerBase
{
    private readonly IOrdersService _service;
    private readonly IMapper _mapper;

    public OrdersController(OrdersContext context, IMapper mapper)
    {
        _service = new OrdersService(context);
        _mapper = mapper;
    }

    [HttpGet("getOrders")]
    public async Task<IActionResult> GetOrders()
    {
        var orders = await _service.GetAll();
        if (orders.Count == 0)
            return NotFound();
        return Ok(_mapper.Map<List<OrderResult>>(orders));
    }

    [HttpPost("AddOrder")]
    public async Task<IActionResult> AddOrder([FromQuery] OrderDto orderDto)
    {
        var newOrder = _mapper.Map<OrderData>(orderDto);
        await _service.AddOrder(newOrder);
        return Ok();
    }
}