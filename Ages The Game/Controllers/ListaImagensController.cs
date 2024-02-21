using Ages_The_Game.Data;
using Ages_The_Game.Models;
using Ages_The_Game.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ages_The_Game.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaImagensController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public readonly IListaImagemRepositorio _imagensRepositorio;

        public ListaImagensController(IListaImagemRepositorio imagensRepositorio, AppDbContext dbContext)
        {
            _imagensRepositorio = imagensRepositorio;
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<ListaImagensModels>>> BuscarTodosItens()
        {
            List<ListaImagensModels> listas = await _imagensRepositorio.BuscarTodosItens();


            return Ok(listas);
        }

        // GET api/<ListaImagensController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<ListaImagensModels>>> BuscarPorId(int id)
        {
            ListaImagensModels imagens = await _imagensRepositorio.BuscarPorId(id);


            return Ok(imagens);
        }

        // POST api/<ListaImagensController>
        [HttpPost]
        public async Task<ActionResult<List<ListaImagensModels>>> Cadastrar([FromBody] ListaImagensModels ImagensModels)
        {
            ListaImagensModels lista = await _imagensRepositorio.Adicionar(ImagensModels);

            return Ok(lista);
        }

        // PUT api/<ListaImagensController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ListaImagensModels>> Atualizar(int id, [FromBody] ListaImagensModels ImagensModels)
        {
            ImagensModels.Id = id;
            ListaImagensModels imagens = await _imagensRepositorio.Atualizar(ImagensModels, id);

            return Ok(imagens);
        }

        // DELETE api/<ListaImagensController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ListaImagensModels>> Apagar(int id)
        {
            bool imagens = await _imagensRepositorio.Apagar(id);

            return Ok(imagens);
        }
    }
}
