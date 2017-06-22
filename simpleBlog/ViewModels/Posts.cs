﻿using simpleBlog.Infrastructure;
using simpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simpleBlog.ViewModels
{
    public class PostsIndex
    {
        public PagedData<Post> Posts { get; set; }
    }

    public class PostsShow
    {
        public Post Post { get; set; }
    }

    public class PostsTag
    {
        public Tag Tag { get; set; }
        public PagedData<Post> Posts { get; set; }
    }
}