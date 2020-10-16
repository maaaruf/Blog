﻿using Blog.Framework.Entities;
using Blog.Framework.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Services.Articles
{
    public class ArticleService : IArticleService
    {
        public IArticleUnitOfWork _articleUnitOfWork { get; set; }

        public ArticleService(IArticleUnitOfWork articleUnitOfWork)
        {
            _articleUnitOfWork = articleUnitOfWork;
        }


        //summary
        // Get a list of all article from DB
        //summary
        public IList<Article> GetAll()
        {
            var articles = _articleUnitOfWork.ArticleRepository.GetAll();
            return articles;
        }


        //summary
        // Create a Article
        //summary
        public void Create(Article article)
        {
            _articleUnitOfWork.ArticleRepository.Add(article);
            _articleUnitOfWork.BeginTransaction();
            _articleUnitOfWork.Commit();
        }

        public void Update(Article article)
        {
            _articleUnitOfWork.ArticleRepository.Edit(article);
            _articleUnitOfWork.BeginTransaction();
            _articleUnitOfWork.Commit();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Article article)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            _articleUnitOfWork.ArticleRepository.Remove(id);
            _articleUnitOfWork.BeginTransaction();
            _articleUnitOfWork.Commit();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Article GetById(int id)
        {
            Article article = _articleUnitOfWork.ArticleRepository.GetById(id);
            return article;
        }
    }
}
