using PieShopApp.Models;
using System.Collections.Generic;

namespace PieShopApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
