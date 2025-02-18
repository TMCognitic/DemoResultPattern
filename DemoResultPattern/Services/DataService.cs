using DemoResultPattern.Entities;
using DemoResultPattern.Patterns.ResultPattern;
using DemoResultPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoResultPattern.Services
{
    public class DataService : IDataRepository
    {
        private readonly List<Data> _items;

        public DataService()
        {
            _items = new List<Data>()
            {
                new Data(1, "Value 1"),
                new Data(2, "Value 2"),
                new Data(3, "Value 3"),
                new Data(4, "Value 4")
            };
        }

        public Result<IEnumerable<Data>> Get()
        {
            try
            {
                IEnumerable<Data> items = _items;
                return Result<IEnumerable<Data>>.Success(items);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<Data>>.Failure(ex.Message, ex);
            }
        }

        public Result Insert(string value)
        {
            try
            {
                if (_items.Any(i => i.Value == value))
                {
                    return Result.Failure("La valeur de la variable 'value' existe déjà", null);
                }

                _items.Add(new Data((_items.Count > 0) ? _items.Max(x => x.Id) + 1 : 1, value));
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure(ex.Message, ex);
            }            
        }
    }
}
