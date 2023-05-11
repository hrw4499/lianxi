using System;
using System.Collections.Generic;

namespace EfCoreDemo.API.Entities
{
    public partial class Person
    {
        public int PId { get; set; }
        public string PName { get; set; } = null!;
        public int PAge { get; set; }
        public string PGender { get; set; } = null!;
    }
}
