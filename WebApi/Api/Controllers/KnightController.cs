using Application.Interfaces;
using Application.ViewModel;
using Application.ViewModel.Request;
using Application.ViewModel.Response;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KnightController : ControllerBase
    {
        private readonly IKnightService _knightService;

        public KnightController(IKnightService knightService)
        {
            _knightService = knightService;
        }

        [HttpGet("knights")]
        public async Task<IActionResult> GetKnights([FromQuery]string filter = "")
        {
            return Ok(await _knightService.GetKnights(filter));
        }

        [HttpPost("knights")]
        public async Task<IActionResult> CreateKnights([FromBody] KnightRequest knight)
        {
            return Ok(await _knightService.CreateKnights(knight));
        }


        [HttpGet("getknight-by-id/{id}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK, Type = typeof(KnightResponse))]
        [ProducesResponseType(typeof(int), StatusCodes.Status404NotFound, Type = typeof(KnightResponse))]
        public async Task<IActionResult> GetKnightById(int id)
        {
            if(!await _knightService.Exists(id))
                return NotFound();

            return Ok(await _knightService.GetKnightById(id));
        }


        [HttpDelete("knights/{id}")]
        public async Task<IActionResult> DeleteKnight(int id)
        {
            if (!await _knightService.Exists(id))
                return NotFound();

            await _knightService.SendHallOfHeroes(id);
            return Ok();
        }


        [HttpPatch("knights/{id}")]
        public async Task<IActionResult> UpdateKnight(int id, [FromBody]string nickName)
        {
            if (!await _knightService.Exists(id))
                return NotFound();

            await _knightService.UpdateKnight(id, nickName);
            return Ok();
        }

    }
}
