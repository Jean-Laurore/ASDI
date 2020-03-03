using System;
namespace Week2_Day1
{
    public class Furniture
    {
        private string type;
        private int price;



        public Furniture(string t, int p)
        {
            type = t;
            price = p;
        }

        public override string ToString()
        {
            return type + " " + price;
        }
    }
}
