namespace GrubGlider.BuildingBlocks.Functional;

public record ErrorResult(
    string Title,
    ErrorType ErrorType,
    string Detail)
{
    public static ErrorResult ValidationError(string title, string detail) =>
        new(title, ErrorType.Validation, detail);

    public static ErrorResult ValidationError(string detail) =>
        new("Validation problem", ErrorType.Validation, detail);

    public static ErrorResult NotFoundError(string title, string detail) =>
        new(title, ErrorType.NotFound, detail);

    public static ErrorResult NotFoundError(string detail) =>
        new("Entity not found", ErrorType.NotFound, detail);

    public static ErrorResult ConflictError(string title, string detail) =>
        new(title, ErrorType.Conflict, detail);

    public static ErrorResult ConflictError(string detail) =>
        new("Entity conflict", ErrorType.Conflict, detail);
}

public enum ErrorType
{
    Validation = 0,
    NotFound = 1,
    Conflict = 2,
}