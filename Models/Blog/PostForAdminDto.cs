using System.Collections.Generic;

namespace Aohost.Blog.BlazorApp.Models.Blog
{
    public class PostForAdminDto : PostDto
    {
        /// <summary>
        /// 标签列表
        /// </summary>
        public IEnumerable<string> Tags { get; set; }
    }
}