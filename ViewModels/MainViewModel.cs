using Menu.Logic;
using Menu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private readonly IMealRepository _mealRepository;
        private ICollection<Meal> _meals;

        private DayOfWeek _dayDisplayed;

        public MainViewModel(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
            _meals = _mealRepository.GetThisWeekMeals();
            _dayDisplayed = DateTime.Now.DayOfWeek;
        }

        public ICollection<Meal> Meals
        {
            get => _meals;
            set 
            {
                if (_meals != value)
                {
                    _meals = value;
                }
                OnPropertyChanged(nameof(Meals));
            }
        }

    }
}
