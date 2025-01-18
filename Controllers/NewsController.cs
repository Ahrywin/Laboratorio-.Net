using Microsoft.AspNetCore.Mvc;

namespace Laboratorio_.Net.Controllers;


public class NewsController : ControllerBase
{

    private readonly IConfiguration _configuration;
    private readonly INewsService newsService;

    public NewsController(IConfiguration configuration, INewsService service)
    {
        _configuration = configuration;
        newsService = service;
    }

    [HttpPost]
    [Route("api/news")]
    public async Task<IActionResult> PostNews([FromBody] NewsDTO news)
    {
        if (news == null)
        {
            return BadRequest("No se pudo procesar la solicitud.");
        }

        var result = await newsService.SaveNews(news);
        if (result)
        {
            return Ok();
        }
        else
        {
            return BadRequest("No se pudo procesar la solicitud.");
        }
    }



}
