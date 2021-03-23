using Menu.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Logic
{
    public class TempMealRepository : IMealRepository
    {
        private readonly MealFaker _mealFaker;
        private readonly ICollection<Meal> _meals;
        private readonly DateTime _currentWeekStart;
        private readonly DateTime _nextWeekStart;

        public TempMealRepository(MealFaker mealFaker)
        {
            _currentWeekStart = DateTime.Today.AddDays(
                1 - (int)DateTime.Today.DayOfWeek);
            _nextWeekStart = _currentWeekStart.AddDays(7);
            _mealFaker = mealFaker;
            _meals = _mealFaker.Generate(40);
        }

        public ICollection<Meal> GetThisWeekMeals()
        {
            return _meals.Where(m => m.Date > _currentWeekStart && m.Date < _currentWeekStart.AddDays(7)).ToList();
        }
        public ICollection<Meal> GetNextWeekMeals()
        {
            return _meals.Where(m => m.Date > _nextWeekStart && m.Date < _nextWeekStart).ToList();
        }
    }
}
