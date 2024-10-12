using Microsoft.AspNetCore.Http;

namespace Solstice.Domain.Exceptions;

/// <summary>
/// Represents an exception that is thrown when there is an error.
/// </summary>
public class CoreException : Exception
{
    public int StatusCode { get; }

    public CoreException(string message)
        : base(message)
    {
    }

    public CoreException(int statusCode, string message)
        : base(message)
    {
        StatusCode = statusCode;
    }

    public CoreException(int statusCode, string message, Exception innerException)
        : base(message, innerException)
    {
        StatusCode = statusCode;
    }

    public CoreException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public static CoreException Format(CoreExceptionEnum coreExceptionEnum, params object[] values)
    {
        return new CoreException(string.Format(coreExceptionEnum.Get(), values));
    }

    public static CoreException Format(int statusCode, CoreExceptionEnum coreExceptionEnum, params object[] values)
    {
        return new CoreException(statusCode, string.Format(coreExceptionEnum.Get(), values));
    }

    public static CoreException Format(Exception ex, CoreExceptionEnum coreExceptionEnum, params object[] values)
    {
        return new CoreException(string.Format(coreExceptionEnum.Get(), values), ex);
    }

    public static CoreException Format(Exception ex, int statusCode, CoreExceptionEnum coreExceptionEnum,
        params object[] values)
    {
        return new CoreException(statusCode, string.Format(coreExceptionEnum.Get(), values), ex);
    }

    /// <summary>
    /// Used to generate exception message based on the provided <see cref="CoreExceptionEnum"/>.
    /// </summary>
    /// <param name="coreExceptionEnum"></param>
    /// <returns></returns>
    public static CoreException Format(CoreExceptionEnum coreExceptionEnum)
    {
        return new CoreException(coreExceptionEnum.Get());
    }

    /// <summary>
    /// Generate a 400 error with or without a message.
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    public static CoreException Error400(params object[] values)
    {
        return values.Length == 0
            ? new CoreException(StatusCodes.Status400BadRequest, CoreExceptionEnum.HTTP_400.Get())
            : new CoreException(StatusCodes.Status400BadRequest,
                string.Format(CoreExceptionEnum.HTTP_400_WITH_MESSAGE.Get(), values));
    }

    /// <summary>
    /// Generate a 401 error with or without a message.
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    public static CoreException Error401(params object[] values)
    {
        return values.Length == 0
            ? new CoreException(StatusCodes.Status401Unauthorized, CoreExceptionEnum.HTTP_401.Get())
            : new CoreException(StatusCodes.Status401Unauthorized,
                string.Format(CoreExceptionEnum.HTTP_401_WITH_MESSAGE.Get(), values));
    }

    /// <summary>
    /// Generate a 403 error with or without a message.
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    public static CoreException Error403(params object[] values)
    {
        return values.Length == 0
            ? new CoreException(StatusCodes.Status403Forbidden, CoreExceptionEnum.HTTP_403.Get())
            : new CoreException(StatusCodes.Status403Forbidden,
                string.Format(CoreExceptionEnum.HTTP_403_WITH_MESSAGE.Get(), values));
    }

    /// <summary>
    /// Generate a 404 error with or without a message.
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    public static CoreException Error404(params object[] values)
    {
        return values.Length == 0
            ? new CoreException(StatusCodes.Status404NotFound, CoreExceptionEnum.HTTP_404.Get())
            : new CoreException(StatusCodes.Status404NotFound,
                string.Format(CoreExceptionEnum.HTTP_404_WITH_MESSAGE.Get(), values));
    }

    /// <summary>
    /// Generate a 500 error with or without a message.
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    public static CoreException Error500(params object[] values)
    {
        return values.Length == 0
            ? new CoreException(StatusCodes.Status500InternalServerError, CoreExceptionEnum.HTTP_500.Get())
            : new CoreException(StatusCodes.Status500InternalServerError,
                string.Format(CoreExceptionEnum.HTTP_500_WITH_MESSAGE.Get(), values));
    }
}