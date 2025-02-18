using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoResultPattern.Entities
{
    public class Data
    {
        public int Id { get; }
        public string Value { get; }
        public Data(int id, string value)
        {
            Id = id;
            Value = value;
        }
    }
}
