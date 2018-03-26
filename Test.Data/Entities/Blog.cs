using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Test.Data.Entities
{
    public class Blog : Entity<int>
    {
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }
}
