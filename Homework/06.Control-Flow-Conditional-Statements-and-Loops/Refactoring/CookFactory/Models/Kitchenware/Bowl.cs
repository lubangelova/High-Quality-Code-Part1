using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookFactory.Contracts;

namespace CookFactory.Models.Kitchenware
{
    public class Bowl : IBowl
    {
        private IList<IVegetable> vegetables;

        public Bowl()
        {
            this.vegetables = new List<IVegetable>();
        }    

        public void Add(IVegetable vegetable)
        {
            this.vegetables.Add(vegetable);
        }
    }
}
