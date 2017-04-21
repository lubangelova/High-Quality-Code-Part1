using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactoringIfStatement.Models;

namespace RefactoringIfStatement
{
    public class IfStatement
    {
        public void RefactoringIfStatemens()
        {
            //Task 1
            Potato potato = new Potato();
            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    this.Cook(potato);
                }
            }
            
            //Task 2
            const int MIN_X = default(int);
            const int MAX_X = default(int);
            const int MAX_Y = default(int);
            const int MIN_Y = default(int);

            int x = default(int);
            int y = default(int);

            bool shouldVisitCell = default(bool);

            bool isXInRange = MIN_X <= x && x <= MAX_X;
            bool isYInRange = MIN_Y <= y && y <= MAX_Y;

            if (isXInRange && isYInRange && shouldVisitCell)
            {
                this.VisitCell();
            }
        }

        private void VisitCell()
        {
            throw new NotImplementedException();
        }

        private void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }
    }
}
