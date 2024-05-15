namespace Domain.ShareKernel;

public enum ErrorType
{
    /// <summary>
    /// Represents a failure error type.
    /// </summary>
    Failure = 0,

    /// <summary>
    /// Represents a validation error type.
    /// </summary>
    Validation = 1,

    /// <summary>
    /// Represents a not found error type.
    /// </summary>
    NotFound = 2,

    /// <summary>
    /// Represents a conflict error type.
    /// </summary>
    Conflict = 3
}
