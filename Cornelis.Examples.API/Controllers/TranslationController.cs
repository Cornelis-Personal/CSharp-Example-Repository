using Cornelis.Examples.Models.Common.Enums;
using Cornelis.Examples.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cornelis.Examples.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationController : ControllerBase
    {
        private ITranslationService TranslationService { get; }

        /// <summary>
        /// Constructor.
        ///
        /// Use dependency injection to get the business logic we will be working with.
        /// </summary>
        public TranslationController(ITranslationService translationService)
        {
            TranslationService = translationService;
        }

        /// <summary>
        /// Translate text from one language into another.
        ///
        /// We use a simple endpoint here has API endpoints
        /// are meant to be simple routing. We handle the logic
        /// in the Services/Business Logic Layer.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <response code="200">Returns translated string</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        [HttpGet("Translate")]
        public IActionResult TranslateAsync(
            [FromQuery] Languages from,
            [FromQuery] Languages to,
            [FromQuery] string input) =>
                Ok(TranslationService.Translate(from, to, input));
    }
}