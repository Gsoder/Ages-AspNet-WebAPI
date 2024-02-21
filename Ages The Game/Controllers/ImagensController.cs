using Ages_The_Game.Data;
using Ages_The_Game.Models;
using Ages_The_Game.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ages_The_Game.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagensController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public readonly IImagensRepositorio _imagensRepositorio;

        public ImagensController(IImagensRepositorio imagensRepositorio, AppDbContext dbContext)
        {
            _imagensRepositorio = imagensRepositorio;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<ImagensModels>>> BuscarTodasImagens()
        {
            List<ImagensModels> listas = await _imagensRepositorio.BuscarTodasImagens();


            return Ok(listas);
        
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<ImagensModels>> BuscarPorId(int id)
        {
            ImagensModels imagens = await _imagensRepositorio.BuscarPorId(id);

            

            return Ok(imagens);
        }

        // POST api/<ImagensController>
        [HttpPost]
        public async Task<ActionResult<ImagensModels>> Cadastrar([FromBody] ImagensModels ImagensModels)
        {


            ImagensModels lista = await _imagensRepositorio.Adicionar(ImagensModels);

            return Ok(lista);
        }

        // PUT api/<ImagensController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ImagensModels>> Atualizar(int id, [FromBody] ImagensModels ImagensModels)
        {
            ImagensModels.Id = id;
            ImagensModels imagens = await _imagensRepositorio.Atualizar(ImagensModels, id);

            return Ok(imagens);
        }

        // DELETE api/<ImagensController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ImagensModels>> Apagar(int id)
        {
            bool imagens = await _imagensRepositorio.Apagar(id);

            return Ok(imagens);
        }
    }
}
