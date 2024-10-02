namespace Radiant.Domain.Extensions
{
    public static class IEnumerableExtensions
    {

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
        {
            return !(list != null && list.Any());
        }

        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> list)
        {
            return list is not null && list.Any();
        }
    }
}
