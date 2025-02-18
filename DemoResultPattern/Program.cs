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
