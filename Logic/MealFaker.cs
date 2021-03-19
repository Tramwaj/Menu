using Bogus;
using Menu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Logic
{
    public class MealFaker : Faker<Meal>
    {        
        public MealFaker()
        {
            var _weekStart = DateTime.Today.AddDays(
                1 - (int)DateTime.Today.DayOfWeek);
            StrictMode(false);            
            RuleFor(m => m.Name, f => f.Company.CompanyName());
            RuleFor(m => m.Type, f => f.Company.CompanySuffix());
            RuleFor(m => m.Description, f => f.Company.Bs());
            RuleFor(m => m.Date, f => f.Date.Between(_weekStart, DateTime.Now.AddDays(14)));
        }
    }
}
