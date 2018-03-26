using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Test.Data.Enums;

namespace Test.Data.Entities
{
    public class Post : Entity<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Status Status { get; set; }
        public Blog Blog { get; set; }
    }
}
