using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookFactory.Models.Vegatables
{
    public class Potato : Vegetable
    {
        public Potato() : base(false, false)
        {
        }

        public Potato(bool isPeeled, bool isCut) : base(isPeeled, isCut)
        {
        }
    }
}
