namespace Radiant.NET.Domain.Extensions
{
    public static class IQueryableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IQueryable<T> list)
        {
            return !(list != null && list.Any());
        }

        public static bool IsNotNullOrEmpty<T>(this IQueryable<T> list)
        {
            return list is not null && list.Any();
        }
    }
}
