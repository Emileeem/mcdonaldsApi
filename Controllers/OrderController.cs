using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace McDonaldsAPI.Controllers;

using Services;

[ApiController]
[Route("order")]
public class OrderController : ControllerBase
{
    [HttpPost("create/{storeId}")]
    public async Task<ActionResult> CreateOrder(int storeId, 
        [FromServices]IOrderRepository repo)
    {
        try
        {
            var orderId = await repo.CreateOrder(storeId);
            return Ok(orderId);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("cancelOrders")]
    public async Task<ActionResult> CancelOrder(int orderId, 
        [FromServices]IOrderRepository repo)
    {
        try
        {
            await repo.CancelOrder(orderId);
            return Ok(orderId);            
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}