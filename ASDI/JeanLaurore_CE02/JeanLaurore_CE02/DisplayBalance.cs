using System;
namespace JeanLaurore_CE02
{
    public class DisplayBalance
    {
        public decimal displayB;

        public DisplayBalance(decimal _displayB)
        {
            displayB = _displayB;
        }

        public decimal GetDisplayB()
        {
            return displayB;
        }

        public decimal SetDisplayB(decimal _displayB)
        {
            this.displayB = _displayB;
            return displayB;
        }
    }
}
