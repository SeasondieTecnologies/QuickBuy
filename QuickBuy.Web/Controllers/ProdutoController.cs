﻿using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController:Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            //_produtoRepositorio = new ProdutoRepositorio(new Repositorio.Contexto.QuickBuyContexto());
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepositorio.ObterTodos());
               
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
                
                _produtoRepositorio.Adicionar(produto);
                return Created("api/produto",produto);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
