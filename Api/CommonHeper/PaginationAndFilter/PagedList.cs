using Microsoft.EntityFrameworkCore;

namespace JwtRoledBasedAuth.CommonHeper.PaginationAndFilter
{
    public class PagedList<T>
    {
        public List<T> Items { get; }
        public int Page { get; }
        public int PageSize { get; }
        public int TotalCount { get; }
        public bool HasNextPage => Page * PageSize < TotalCount;
        public bool HasPreviousPage => Page > 1;

        public PagedList(List<T> items, int page, int pageSize, int totalCount)
        {
            Items = items;
            Page = page;
            PageSize = pageSize;
            TotalCount = totalCount;
        }

        public static async Task<PagedList<T>> CreateAsync(
            IQueryable<T> query, int page, int pageSize)
        {
            var count = await query.CountAsync();
            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return new PagedList<T>(items, page, pageSize, count);
        }
    }
}
