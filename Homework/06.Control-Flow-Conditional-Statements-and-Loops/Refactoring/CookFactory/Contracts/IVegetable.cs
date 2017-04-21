using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookFactory.Contracts
{
    public interface IVegetable
    {
        bool IsPeeled { get; set; }

        bool IsCut { get; set; }
    }
}
