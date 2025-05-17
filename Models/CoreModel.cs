namespace Solstice.Domain.Models;

/// <summary>
/// CoreModel class provides a structure to encapsulate information related
/// to Solstice functionality in the application. The information mainly includes
/// id associated to each Solstice transaction or operation.
/// </summary>
public class CoreModel
{
    /// <summary>
    /// Gets or sets the unique identifier for the Solstice operation.
    /// </summary>
    public int Id { get; set; }
}