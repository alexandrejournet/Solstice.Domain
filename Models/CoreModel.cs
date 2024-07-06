namespace Radiant.NET.Domain.Models;

/// <summary>
/// CoreModel class provides a structure to encapsulate information related
/// to Radiant.NET functionality in the application. The information mainly includes
/// id associated to each Radiant.NET transaction or operation.
/// </summary>
public class CoreModel
{
    /// <summary>
    /// Gets or sets the unique identifier for the Radiant.NET operation.
    /// </summary>
    public int Id { get; set; }
}