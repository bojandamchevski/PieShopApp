using System.Collections.Generic;

namespace PieShopApp.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
