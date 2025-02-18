// See https://aka.ms/new-console-template for more information
using DemoResultPattern.Entities;
using DemoResultPattern.Patterns.ResultPattern;
using DemoResultPattern.Repositories;
using DemoResultPattern.Services;

IDataRepository repository = new DataService();

Console.WriteLine(repository.Insert("Value 5"));
Console.WriteLine(repository.Insert("Value 5"));

Result<IEnumerable<Data>> result = repository.Get();

if(result.IsFailure)
{
    Console.WriteLine(result.ErrorMessage);
    return;
}

foreach(Data data in result.Content)
{
    Console.WriteLine(data.Value);
}


/// <summary>
/// Refresh sur le CQS de la correction du 17/02/2025
/// </summary>
public interface ICommandDefinition
{
}

public interface ICommandHandler<TCommand>
    where TCommand : ICommandDefinition
{
    Result Execute(TCommand command);
}

public interface ICommandAsyncHandler<TCommand>
    where TCommand : ICommandDefinition
{
    Task<Result> ExecuteAsync(TCommand command);
}

public interface IQueryDefinition<TResult>
{
}

public interface IQueryHandler<TQuery, TResult>
    where TQuery : IQueryDefinition<TResult>
{
    Result<TResult> Execute(TQuery command);
}

public interface IQueryAsyncHandler<TQuery, TResult>
    where TQuery : IQueryDefinition<TResult>
{
    Task<Result<TResult>> ExecuteAsync(TQuery command);
}