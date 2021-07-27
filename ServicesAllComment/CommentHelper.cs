﻿using DataProvider;
using Model;
using Repositories.Interfaces;
using Repositories.Repositor;
using ServicesAllComment.Intarface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CommentHelper: ICommentHelper
    {
        private IGenericRepository<Comment> _comentRepository = new CommentRepository(new DataProvider.CommentContext());
        public void Set(string UserName,string comment)
        {
            Comment com = new Comment();
            com.UserName = UserName;
            com.TextComment = comment;
            com.Date = DateTime.Now;
            _comentRepository.Add(com);
        }
      

    }
}