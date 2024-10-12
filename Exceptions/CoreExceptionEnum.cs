namespace Solstice.Domain.Exceptions;

/// <summary>
/// Represents the possible exceptions that can be thrown by the Solstice.Domain classes.
/// </summary>
public enum CoreExceptionEnum
{
    NO_REPOSITORY,
    NO_SERVICE,
    NO_QUERY_DTO,
    HTTP_400,
    HTTP_400_WITH_MESSAGE,
    HTTP_401,
    HTTP_401_WITH_MESSAGE,
    HTTP_403,
    HTTP_403_WITH_MESSAGE,
    HTTP_404,
    HTTP_404_WITH_MESSAGE,
    HTTP_500,
    HTTP_500_WITH_MESSAGE
}

/// <summary>
/// Provides extension methods for the <see cref="CoreExceptionEnum"/> enumeration.
/// </summary>
public static class CoreExceptionEnumExtension
{
    /// <summary>
    /// Gets the error message associated with the specified <see cref="CoreExceptionEnum"/> value.
    /// </summary>
    /// <param name="coreExceptionEnum">The <see cref="CoreExceptionEnum"/> value.</param>
    /// <returns>The error message associated with the specified <see cref="CoreExceptionEnum"/> value.</returns>
    public static string Get(this CoreExceptionEnum coreExceptionEnum)
    {
        return coreExceptionEnum switch
        {
            CoreExceptionEnum.NO_REPOSITORY =>
            "You are using the 'AddRepositories()' method, but none of your repositories has the [Repository] annotation. Set at least one of them to remove this warning.",
            CoreExceptionEnum.NO_SERVICE =>
            "You are using the 'AddServices()' method, but none of your services has the [Service] annotation. Set at least one of them to remove this warning.",
            CoreExceptionEnum.NO_QUERY_DTO =>
            "You are using the 'AddQueryDtoToDbContext()' method, but none of your DTOs has the [Query] annotation. Set at least one of them to remove this warning.",
            CoreExceptionEnum.HTTP_400 =>
            "The request is invalid.",
            CoreExceptionEnum.HTTP_400_WITH_MESSAGE =>
            "The request is invalid: {0}",
            CoreExceptionEnum.HTTP_401 =>
            "You are not authorized to access this resource.",
            CoreExceptionEnum.HTTP_401_WITH_MESSAGE =>
            "You are not authorized to access this resource: {0}",
            CoreExceptionEnum.HTTP_403 =>
            "You are not authorized to access this resource.",
            CoreExceptionEnum.HTTP_403_WITH_MESSAGE =>
            "You are not authorized to access this resource: {0}",
            CoreExceptionEnum.HTTP_404 =>
            "No result found.",
            CoreExceptionEnum.HTTP_404_WITH_MESSAGE =>
            "No result found for the specified parameters: {0}",
            CoreExceptionEnum.HTTP_500 =>
            "An error occurred while processing your request.",
            CoreExceptionEnum.HTTP_500_WITH_MESSAGE =>
            "An error occurred while processing your request: {0}",
            _ => ""
        };
    }
}