using System;
using Boilerplate.Data.Models;

namespace Boilerplate.Data.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Year { get; set; }
    }
}