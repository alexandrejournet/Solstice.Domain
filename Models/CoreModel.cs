namespace Radiant.Domain.Models;

/// <summary>
/// CoreModel class provides a structure to encapsulate information related
/// to Radiant functionality in the application. The information mainly includes
/// id associated to each Radiant transaction or operation.
/// </summary>
public class CoreModel
{
    /// <summary>
    /// Gets or sets the unique identifier for the Radiant operation.
    /// </summary>
    public int Id { get; set; }
}