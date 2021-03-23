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
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string Day { get => Date.ToString("dddd"); }
        public int DayNo { get => (int)Date.DayOfWeek; }

        public string Image { get; set; }
    }
}
