namespace Aohost.Blog.BlazorApp.Models.Base.Paged
{
    public interface IPagedList<T> : IListResult<T>, IHasTotalCount
    {
    }
}