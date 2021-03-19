using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Menu.Model
{
    public class Meal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DayOfWeek Day { get => Date.DayOfWeek; }
            
        public Image Image { get; set; }
    }
}
