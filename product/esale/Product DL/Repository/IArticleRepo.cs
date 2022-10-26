using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDL.Repository
{
    public interface IArticleRepo
    {
        void AddArticle(Article article);
        void UpdateArticle(Article article);
        void DeleteArticle(int articleid);
        Article GetArticleById(int articleid);
        IEnumerable<Article> GetArticles();
    }
}
