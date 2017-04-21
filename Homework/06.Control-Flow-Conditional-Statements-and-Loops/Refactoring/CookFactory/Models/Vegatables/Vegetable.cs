using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookFactory.Contracts;

namespace CookFactory.Models.Vegatables
{
    public abstract class Vegetable : IVegetable
    {
        private bool isPeeled;
        private bool isCut;

        public Vegetable() : this(false, false)
        {
        }

        public Vegetable(bool isPeeled, bool isCut)
        {
            this.IsPeeled = isPeeled;
            this.IsCut = isCut;
        }

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }

            set
            {
                if (this.isPeeled && !value)
                {
                    throw new ArgumentException("The vegatable is already peeled!");
                }

                this.isPeeled = value;
            }
        }

        public bool IsCut
        {
            get
            {
                return this.isCut;
            }

            set
            {
                if (this.isCut && !value)
                {
                    throw new ArgumentException("The vegatable is already cut!");
                }

                this.isCut = value;
            }
        }
    }
}
