using System.Collections.Generic;
using System.Linq;
using car_rentals_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace car_rentals_project.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderControler : ControllerBase
    {
        private readonly DataContext _context;

        public OrderControler(DataContext context) =>
            _context = context;

        private static List<Order> orders = new List<Order>();

        // GET: /api/client/listar
        [Route("listar")]
        [HttpGet]
        public IActionResult Listar() =>
            Ok(_context.Order.ToList());

        // POST: /api/client/cadastrar
        [Route("cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Order order)
        {
            _context.Order.Add(order);
            _context.SaveChanges();
            return Created("", order);
        }

        // GET: /api/client/buscar/123
        [Route("buscar/{number}")]
        [HttpGet]
        public IActionResult Buscar([FromRoute] int number)
        {
            Order order =
                _context.Order.FirstOrDefault
            (
                o => o.number.Equals(number)
            );

            return order != null ? Ok(order) : NotFound();
        }

        // DELETE: /api/client/deletar/1
        [Route("deletar/{id}")]
        [HttpDelete]
        public IActionResult Deletar([FromRoute] int id)
        {
            Order order =
                _context.Order.Find(id);
            if (order != null)
            {
                _context.Order.Remove(order);
                _context.SaveChanges();
                return Ok(order);
            }
            return NotFound();
        }

        // PATCH: /api/client/alterar
        [Route("alterar")]
        [HttpPatch]
        public IActionResult Alterar([FromBody] Order order)
        {
            _context.Order.Update(order);
            _context.SaveChanges();
            return Ok(order);
        }
    }
}