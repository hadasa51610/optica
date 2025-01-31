﻿using Microsoft.AspNetCore.Mvc;
using Optica.Core.Entites;
using Optica.Core.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Optica.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IService<Order> _orderService;
        public OrderController(IService<Order> orderService)
        {
            _orderService = orderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            List<Order> orders = _orderService.GetAll().ToList();
            return orders == null ? NotFound() : orders;
        }

        // GET api/<OrderController>/5
        [HttpGet("{orderCode}")]
        public ActionResult<Order> Get(string orderCode)
        {
            Order order = _orderService.GetById(orderCode);
            return order == null ? NotFound() : order;
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<Order> Post([FromBody] Order order)
        {
            if (order == null) return BadRequest("Order data is required.");
            Order o = _orderService.Add(order);
            return o == null ? NotFound() : o;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{orderCode}")]
        public ActionResult<Order> Put(string orderCode, [FromBody] Order order)
        {
            if (orderCode == null) return BadRequest();
            if (_orderService.GetById(orderCode) == null) return NotFound();
            Order o = _orderService.Update(orderCode, order);
            return o == null ? NotFound() : o;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{orderCode}")]
        public ActionResult<bool> Delete(string orderCode)
        {
            if (orderCode == null) return BadRequest();
            if (_orderService.GetById(orderCode) == null) return NotFound();
            return _orderService.Delete(orderCode);
        }
    }
}