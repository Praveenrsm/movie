using Microsoft.EntityFrameworkCore;
using Product_DL;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductDL.Repository
{
    public class ArticleRepo : IArticleRepo
    {
        ProductDataContext _productdbcontext;
        public ArticleRepo(ProductDataContext context)
        {
            this._productdbcontext = context;
        }
        public void AddArticle(Article art)
        {
            _productdbcontext.article.Add(art);
            _productdbcontext.SaveChanges();
        }
        public void DeleteArticle(int artid)
        {
            var article = _productdbcontext.article.Find(artid);
            _productdbcontext.article.Remove(article);
            _productdbcontext.SaveChanges();
        }
        public IEnumerable<Article> GetArticles()
        {
            return _productdbcontext.article.ToList();
        }
        public Article GetArticleById(int artid)
        {
            return _productdbcontext.article.Find(artid);
        }
        public void UpdateArticle(Article art)
        {
            _productdbcontext.Entry(art).State = EntityState.Modified;
            _productdbcontext.SaveChanges();
        }
    }
}
