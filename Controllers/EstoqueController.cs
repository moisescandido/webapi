using System.Net.NetworkInformation;
using Estoque.Models.DTOs;
using Estoque.Models.Entities;
using Estoque.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstoqueController : ControllerBase
    {
        private readonly IProdutoRepository _produto;
        public EstoqueController(IProdutoRepository produto)
        {
            _produto = produto;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Valor Id incorreto");
            }
            else
            {
                return Ok(await _produto.GetById(id));
            }
        }
        [HttpPost]
        public IActionResult Post(ProdutoDTO produtoDTO)
        {
            var produto = new Produto
            {
                Nome = produtoDTO.Nome,
                Quantidade = produtoDTO.Quantidade,
                Preco = produtoDTO.Preco,
                Descricao = produtoDTO.Descricao,
                Categoria = produtoDTO.Categoria
            };
            _produto.Adicionar(produto);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(int id, float preco)
        {
            if (id <= 0)
            {
                return BadRequest("Valor Id incorreto");
            }
            else
            {
                _produto.Deletar(id);
                return Ok();
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Valor Id incorreto");
            }
            else
            {
                _produto.Deletar(id);
                return Ok();
            }
        }
    }
}