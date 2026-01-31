
using Odev12.Models;
using Odev12.Strategy;
using System.Collections.Generic;
using System.Linq;

namespace Odev12.Strategy
{
    public class FilterByPublishYear : IBookFilterStrategy
    {
        public List<Book> Filter(List<Book> books, string searchText)
        {
            if (!int.TryParse(searchText, out int year))    
                return new List<Book>();

            return books
                .Where(b => b.PublishYear == year)
                .ToList();
        }
    }
}
