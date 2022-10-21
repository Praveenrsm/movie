using Product_DL.Repository;
using ProductDL.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBL.Services
{
    public class ArticleService
    {
        IArticleRepo _articleRepository;
        public ArticleService(IArticleRepo articleRepository)
        {
            this._articleRepository = articleRepository;
        }
        public void AddArticle(Article article)
        {
            _articleRepository.AddArticle(article);
        }
        public void UpdateArticle(Article article)
        {
            _articleRepository.UpdateArticle(article);
        }
        public void DeleteArticle(int ArticleId)
        {
            _articleRepository.DeleteArticle(ArticleId);
        }
        //get movie by id
        public Article GetArticleById(int ArticleId)
        {
            return _articleRepository.GetArticleById(ArticleId);
        }
        //get movies
        public IEnumerable<Article> GetArticles()
        {
            return _articleRepository.GetArticles();
        }
    }
}
