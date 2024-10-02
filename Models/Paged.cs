namespace Radiant.Domain.Models;

/// <summary>
/// The 'Paged' class provides a simple way to encapsulate a collection of items with a certain count.
/// It's generic, able to support any type of object (indicated by 'T') for pagination purposes.
/// </summary>
///
/// <typeparam name="T">The type of items held within the 'Paged' object.</typeparam>
///
/// <remarks>
/// Properties include:
///
/// - 'Items': A collection of items of type 'T'. Nullable.
///
/// - 'Count': The total count of items present in the 'Items' collection.
/// </remarks>
public class Paged<T>
{
    public ICollection<T>? Items { get; set; }
    public int Count { get; set; }
}