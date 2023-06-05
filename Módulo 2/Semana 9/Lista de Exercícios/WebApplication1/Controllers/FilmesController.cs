using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/filmes")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        /// <summary>
        /// Requisição para lista mocada de filmes
        /// </summary>
        /// <returns>Retorna uma lista mocada de filmes</returns>
        /// <response code="200">Sucesso no retorno da lista mocada de filmes</response>
        // GET: api/<FilmesController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Filme> Get()
        {
            return MockFilmes.Filmes;
        }

        /// <summary>
        /// Requisição de um item da lista mocada de filmes
        /// </summary>
        /// <param name="id">Id do filme</param>
        /// <returns>Retorno do objeto filme</returns>
        /// <response code="404">Filme não encontrado</response>
        /// <response code="200">Sucesso no retorno do objeto filme</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get(int id)
        {
            Filme filmes = MockFilmes.Filmes.FirstOrDefault(x => x.Id == id);

            if (filmes == null) { 
                return NotFound();
            }

            return Ok(filmes);
        }

        /// <summary>
        /// Criação de um item para a lista mocada de filmes
        /// </summary>
        /// <param name="filme">Dados do filme a ser criado</param>
        /// <returns>Criação do filme realizada com sucesso</returns>
        /// <response code="201">Sucesso na criação do objeto filme</response>
        // POST api/<FilmesController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] Filme filme)
        {
            MockFilmes.Filmes.Add(filme);

            return CreatedAtAction(nameof(Get), new {id = filme.Id}, filme);
        }

        /// <summary>
        /// Atualização de um item para a lista mocada de filmes
        /// </summary>
        /// <param name="id">Id do filme</param>
        /// <param name="filme">Objeto filme</param>
        /// <returns>Atualização do filme</returns>
        /// <response code="404">Filme não encontrado</response>
        /// <response code="204">Sucesso na atualização do objeto filme</response>
        // PUT api/<FilmesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Put(int id, [FromBody] Filme filme)
        {
            Filme filmeUpdate = MockFilmes.Filmes.FirstOrDefault(x=> x.Id == id);

            if (filmeUpdate is null)
            {
                return NotFound();
            }

            var index = MockFilmes.Filmes.IndexOf(filmeUpdate);

            if (index != -1) {
                MockFilmes.Filmes[index] = filme;
            }

            return NoContent();
        }

        /// <summary>
        /// Exclusão de um item da lista mocada de filmes
        /// </summary>
        /// <param name="id">Id do filme</param>
        /// <returns>Remoção do filme</returns>
        /// <response code="404">Filme não encontrado</response>
        /// <response code="204">Sucesso na exclusão do objeto filme</response>
        // DELETE api/<FilmesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete(int id)

        {
            Filme filmeUpdate = MockFilmes.Filmes.FirstOrDefault(x=> x.Id == id);

            if (filmeUpdate is null)
            {
                return NotFound();
            }

            MockFilmes.Filmes.Remove(filmeUpdate);

            return NoContent();

        }
    }
}
