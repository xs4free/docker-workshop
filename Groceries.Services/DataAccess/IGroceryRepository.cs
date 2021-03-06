using System.Collections.Generic;

namespace Groceries.Services
{
    public interface IGroceryRepository
    {
        IEnumerable<Grocery> GetAll();
        void Add(Grocery grocery);
        void Remove(Grocery grocery);
    }
}