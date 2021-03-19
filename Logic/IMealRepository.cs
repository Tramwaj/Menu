using Menu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Logic
{
    public interface IMealRepository
    {
        public ICollection<Meal> GetThisWeekMeals();
        public ICollection<Meal> GetNextWeekMeals();

        
    }
}
