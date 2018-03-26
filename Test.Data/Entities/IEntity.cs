using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Data.Entities
{
    public interface IEntity<T>
    {
        T Id { get; set; }
        DateTime DateCreated { get; set; }
    }
}
