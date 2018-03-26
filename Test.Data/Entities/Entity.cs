using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Test.Data.Entities
{
    public abstract class Entity<T> : IEntity<T>
    {
        [Key]
        public T Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
