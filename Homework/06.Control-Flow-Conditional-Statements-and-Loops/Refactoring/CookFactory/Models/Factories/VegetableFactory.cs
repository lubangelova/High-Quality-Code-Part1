using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookFactory.Models.Vegatables;

namespace CookFactory.Models.Factories
{
    public static class VegetableFactory
    {
        public static Carrot GetCarrot()
        {
            return new Carrot();
        }

        public static Potato GetPotato()
        {
            return new Potato();
        }
    }
}
