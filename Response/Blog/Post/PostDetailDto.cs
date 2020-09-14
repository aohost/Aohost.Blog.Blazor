﻿using System.Collections.Generic;
using Aohost.Blog.BlazorApp.Response.Blog.Category;
using Aohost.Blog.BlazorApp.Response.Blog.Tag;

namespace Aohost.Blog.BlazorApp.Response.Blog.Post
{
    public class PostDetailDto
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// HTML
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// MarkDown
        /// </summary>
        public string MarkDown { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public CategoryDto Category { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        public IEnumerable<TagDto> Tags { get; set; }

        /// <summary>
        /// 上一篇
        /// </summary>
        public PostForPagedDto Previous { get; set; }

        /// <summary>
        /// 下一篇
        /// </summary>
        public PostForPagedDto Next { get; set; }
    }
}