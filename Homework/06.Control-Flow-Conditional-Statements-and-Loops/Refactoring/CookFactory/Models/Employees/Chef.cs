using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookFactory.Models.Factories;
using CookFactory.Models.Kitchenware;
using CookFactory.Models.Vegatables;

namespace CookFactory.Models.Employees
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = VegetableFactory.GetPotato();
            Carrot carrot = VegetableFactory.GetCarrot();           
            this.Peel(potato);
            this.Peel(carrot);
            this.Cut(potato);
            this.Cut(carrot);
            Bowl bowl = BowlFactory.GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.IsCut = true;
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }
    }
}
