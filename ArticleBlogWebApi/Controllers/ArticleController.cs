using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleBlogWebApi.Models;
using ArticleBlogWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleBlogWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase  
    {
        private readonly IDBRepository<Article> _articleService;

        public ArticleController(IDBRepository<Article> ArticleService) 
        {
            _articleService = ArticleService;
        }

        [HttpGet]
        public ActionResult<List<Article>> Get() =>
           _articleService.Get();

        [HttpGet("{id:length(24)}", Name = "GetArticle")]
        public ActionResult<Article> Get(string id)
        {
            var Article = _articleService.Get(id);

            if (Article == null)
            {
                return NotFound();
            }

            return Article;
        }

        [HttpPost]
        public ActionResult<Article> Create(Article Article)
        {
            Article.Created_At = DateTime.UtcNow;
            _articleService.Create(Article);

            return CreatedAtRoute("GetArticle", new { id = Article.Id.ToString() }, Article);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Article ArticleIn)
        {
            var Article = _articleService.Get(id);

            ArticleIn.Created_At = Article.Created_At;
            ArticleIn.Updated_At = DateTime.UtcNow;

            if (Article == null)
            {
                return NotFound();
            }

            _articleService.Update(id, ArticleIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var Article = _articleService.Get(id);

            if (Article == null)
            {
                return NotFound();
            }

            _articleService.Remove(Article.Id);

            return NoContent();
        }
    }
}