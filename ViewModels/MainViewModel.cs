using Menu.Logic;
using Menu.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Menu.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private readonly IMealRepository _mealRepository;
        private ICollection<Meal> _meals;

        private DayOfWeek _dayDisplayed;

       public ListCollectionView MealsView { get; set; }

        public MainViewModel(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
            _meals = _mealRepository.GetThisWeekMeals();
            _dayDisplayed = DateTime.Now.DayOfWeek;
            Meals = new ObservableCollection<Meal>(_meals);
            SetupCollectionView();

        }

        private void SetupCollectionView()
        {
            MealsView = new ListCollectionView(_meals.ToList());
            MealsView.GroupDescriptions.Add(new PropertyGroupDescription("Day"));
            MealsView.SortDescriptions.Add(new SortDescription("DayNo",ListSortDirection.Ascending));
        }

        public ObservableCollection<Meal> Meals { get; set; }
        

    }
}
