using DemoResultPattern.Entities;
using DemoResultPattern.Patterns.ResultPattern;

namespace DemoResultPattern.Repositories
{
    public interface IDataRepository
    {
        Result<IEnumerable<Data>> Get();
        Result Insert(string value);
    }
}
