using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookFactory.Models.Vegatables
{
    public class Carrot : Vegetable
    {
        public Carrot() : base(false, false)
        {
        }

        public Carrot(bool isPeeled, bool isCut) : base(isPeeled, isCut)
        {
        }
    }
}
