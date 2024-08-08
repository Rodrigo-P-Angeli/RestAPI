using Microsoft.AspNetCore.Mvc;
using RestAPI.Application.DTOs;
using RestAPI.Application.Interfaces;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;

namespace RestAPI.Controllers
{
    [Route("Products/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IApplicationServiceProduct applicationServiceProduto;

        public ProductController(IApplicationServiceProduct applicationServiceProduto)
        {
            this.applicationServiceProduto = applicationServiceProduto;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromQuery] int? page, [FromQuery] int? pageSize, [FromQuery] bool? active)
        {
            return Ok(applicationServiceProduto.GetAll(page, pageSize, active));
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceProduto.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProductDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                applicationServiceProduto.Add(produtoDTO);
                return Ok("O produto foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProductDto produtoDTO)
        {

            try
            {
                if (produtoDTO == null )
                    return NotFound();

                applicationServiceProduto.Update(produtoDTO);
                return Ok("O produto foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProductDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                applicationServiceProduto.Remove(produtoDTO);
                return Ok("O produto foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
