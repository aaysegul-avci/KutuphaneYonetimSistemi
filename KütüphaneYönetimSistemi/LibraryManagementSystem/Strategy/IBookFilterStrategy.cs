
using Odev12.Models;
using System.Collections.Generic;

namespace Odev12.Strategy
{
    public interface IBookFilterStrategy
    {
        List<Book> Filter(List<Book> books, string searchText);
    }
}
