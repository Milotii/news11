namespace news11.Services
{
    using news11.Models;
    // Services/NewsService.cs
    using System.Collections.Generic;
    using System.Linq;

    public class NewsService
    {
        private readonly List<NewsArticle> _articles = new List<NewsArticle>();

        public IEnumerable<NewsArticle> GetAllArticles()
        {
            return _articles;
        }

        public NewsArticle GetArticleById(int id)
        {
            return _articles.FirstOrDefault(article => article.Id == id);
        }

        public void AddArticle(NewsArticle article)
        {
            article.Id = _articles.Any() ? _articles.Max(a => a.Id) + 1 : 1;
            _articles.Add(article);
        }

        public void UpdateArticle(NewsArticle updatedArticle)
        {
            var existingArticle = _articles.FirstOrDefault(article => article.Id == updatedArticle.Id);
            if (existingArticle != null)
            {
                existingArticle.Title = updatedArticle.Title;
                existingArticle.Content = updatedArticle.Content;
            }
        }

        public void DeleteArticle(int id)
        {
            var articleToRemove = _articles.FirstOrDefault(article => article.Id == id);
            if (articleToRemove != null)
            {
                _articles.Remove(articleToRemove);
            }
        }
    }

}
