using CSharpFunctionalExtensions;
using GrubGlider.BuildingBlocks.Functional;
using Microsoft.AspNetCore.Http;
using IResult = Microsoft.AspNetCore.Http.IResult;

namespace GrubGlider.BuildingBlocks.Api;

public static class ResultsExtensions
{
    public static IResult ToSuccessOrBadRequest<T>(this Result<T> result) =>
        result.Match(
            onSuccess: Results.Ok,
            onFailure: error => ErrorResult.ValidationError(error).ToApiError()
        );
    public static IResult ToSuccessOrNotFound<T>(this Result<T> result) =>
        result.Match(
            onSuccess: Results.Ok,
            onFailure: error => ErrorResult.NotFoundError(error).ToApiError()
        );
    
    public static IResult ToSuccessOrBadRequest<T>(this Result<T> result, Func<T, IResult> onSuccess) =>
        result.Match(
            onSuccess: onSuccess,
            onFailure: error => ErrorResult.ValidationError(error).ToApiError()
        );

    public static IResult ToApiResponse<T>(this Result<T, ErrorResult> result) =>
        result.Match(
            onSuccess: Results.Ok,
            onFailure: error => error.ToApiError()
        );

    public static IResult ToApiResponse<T>(this Result<T, ErrorResult> result, Func<T, IResult> onSuccess) =>
        result.Match(
            onSuccess: onSuccess,
            onFailure: error => error.ToApiError()
        );

    public static IResult ToApiResponse(this UnitResult<ErrorResult> result) =>
        result.Match(
            onSuccess: () => Results.Ok(),
            onFailure: error => error.ToApiError()
        );

    public static IResult ToApiResponse(this UnitResult<ErrorResult> result, Func<IResult> onSuccess) =>
        result.Match(
            onSuccess: onSuccess,
            onFailure: error => error.ToApiError()
        );

    public static IResult ToApiError(this ErrorResult error) => Results.Problem(
        title: error.Title,
        detail: error.Detail,
        statusCode: error.ErrorType switch
        {
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            _ => StatusCodes.Status500InternalServerError
        }
    );
}