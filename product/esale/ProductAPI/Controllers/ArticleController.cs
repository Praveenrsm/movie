using Microsoft.AspNetCore.Mvc;
using ProductBL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
            private ArticleService _articleservice;
            public ArticleController(ArticleService articleservice)
            {
            _articleservice = articleservice;
            }
            [HttpGet("GetArticle")]
            public IEnumerable<Article> GetArticle()
            {
                return _articleservice.GetArticles();
            }
            [HttpPost("AddArticle")]
            public IActionResult AddArticle([FromBody] Article art)
            {
                _articleservice.AddArticle(art);
                return Ok("Article created successfully");
            }
            [HttpDelete("DeleteArticle")]
            public IActionResult DeleteArticle(int ArticleId)
            {
                _articleservice.DeleteArticle(ArticleId);
                return Ok("Article deleted successfully");
            }
            [HttpPut("UpdateArticle")]
            public IActionResult UpdateArticle([FromBody] Article art)
            {
                _articleservice.UpdateArticle(art);
                return Ok("Article updated successfully");
            }
            [HttpGet("GetArticleById")]
            public Article GetArticleById(int ArticleId)
            {
                return _articleservice.GetArticleById(ArticleId);
            }
        }
}
