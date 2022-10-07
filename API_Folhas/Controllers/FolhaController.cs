using System.Collections.Generic;
using System.Linq;
using API_Folhas.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Folhas.Controllers
{
    [ApiController]
    [Route("api/folha")]
    public class FolhaController : ControllerBase
    {
        private readonly DataContext _context;

        //Injeção de dependência - balta.io
        public FolhaController(DataContext context) =>
            _context = context;

        private static List<FolhaPagamento> folha = new List<FolhaPagamento>();

        // GET: /api/folha/listar
        [Route("listar")]
        [HttpGet]
        public IActionResult Listar() => Ok(_context.Folha.ToList());

        // POST: /api/folha/cadastrar
        [Route("cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] FolhaPagamento folha)
        {
               
            
              
            _context.Folha.Add(folha);
            _context.SaveChanges();
             return Created("", folha);
        }

        // GET: /api/folha/buscar/123
        [Route("buscar/{cpf}/{mes}/{ano}")]
        [HttpGet]
        public IActionResult Buscar([FromRoute] string CriadoEm)
        {
            //Expressão lambda
              FolhaPagamento folha = _context.Folha.FirstOrDefault
            (
                x => x.CriadoEm.Equals(CriadoEm)
                
            );
            //IF ternário
            return folha != null ? Ok(folha) : NotFound();
        }

        // DELETE: /api/folha/deletar/123
        [Route("deletar/{id}")]
        [HttpDelete]
        public IActionResult Deletar([FromRoute] int id)
        {
            FolhaPagamento folha = 
              _context.Folha.Find(id);
              if (folha != null)
            {
             _context.Folha.Remove(folha);
             _context.SaveChanges();
                return Ok(folha);
            }
            return NotFound();
        }

        // PATCH: /api/funcionario/alterar
        [Route("alterar")]
        [HttpPatch]
        public IActionResult Alterar([FromBody] FolhaPagamento folha)
        {
            
                _context.Folha.Update(folha);
                _context.SaveChanges();
                return Ok(folha);
            }
    } 
    
}


