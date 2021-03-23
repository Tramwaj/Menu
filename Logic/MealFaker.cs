using Bogus;
using Menu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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
            RuleFor(m => m.Price, f => f.Random.Decimal(10m, 20m));
            RuleFor(m => m.Description, f => f.Company.Bs() + f.Company.CatchPhrase());
            RuleFor(m => m.Date, f => f.Date.Between(_weekStart, DateTime.Now.AddDays(14)));
            RuleFor(m => m.Image, f =>f.Image.LoremPixelUrl("random",100,100)); 
        }
        private Image getImage(string uri)
        {
            Image img = new Image();
            BitmapImage bitImg= new BitmapImage();
            bitImg.BeginInit();
            bitImg.UriSource = new Uri(uri);
            bitImg.EndInit();
            img.Source = bitImg;
            return img;
        }
    }
}
