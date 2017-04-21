using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookFactory.Models.Kitchenware;

namespace CookFactory.Models.Factories
{
    public static class BowlFactory
    {
        public static Bowl GetBowl()
        {
            return new Bowl();
        }
    }
}
