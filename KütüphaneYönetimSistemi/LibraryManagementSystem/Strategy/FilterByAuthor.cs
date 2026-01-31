
using Odev12.Models;
using Odev12.Strategy;
using System.Collections.Generic;
using System.Linq;

namespace Odev12.Strategy
{
    public class FilterByAuthor : IBookFilterStrategy
    {
        public List<Book> Filter(List<Book> books, string searchText)
        {
            return books
                .Where(b => b.Author
                .ToLower()
                .Contains(searchText.ToLower()))
                .ToList();
        }
    }
}
