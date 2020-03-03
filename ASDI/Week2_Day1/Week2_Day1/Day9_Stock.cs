using System;
using System.Collections.Generic;
using System.IO;

namespace Week2_Day1
{
    public class Day9_Stock
    {
        private string _fileName = "iventory.txt";
        private string _path = @"../../../output/";

        private List<Item> _item = new List<Item>();

        private List<Item> _shoppingCart = new List<Item>();

        public Day9_Stock()
        {
            Load();
            Console.Clear();
            //DisplayInventory();

            _shoppingCart.Add(_item[1]);
            _shoppingCart.Add(_item[0]);

            _item.RemoveAt(1);
            _item.RemoveAt(0);


            DisplayShoppingCart();
            
            Console.WriteLine("===============");
            DisplayInventory();
        }

        private void CheckOut()
        {
            Console.Clear();

            File.Create(_path + "receipt.txt").Dispose();
            using (StreamWriter sw = new StreamWriter(_path + "receipt.tx"))
            {
                decimal total = 0;
                foreach (Item item in _shoppingCart)
                {
                    sw.WriteLine($"{item.Name,-12} {item.Price}");
                    total += item.Price; 
                }
                sw.WriteLine("================");
                sw.WriteLine($"Total: {total.ToString("c")}");
            }
        }

        private void DisplayShoppingCart()
        {
            _shoppingCart.ForEach(Console.WriteLine);
        }

        private void DisplayInventory()
        {
            Console.Clear();

            _item.ForEach(Console.WriteLine);
        }

        private void Load()
        {
            using (StreamReader sr = new StreamReader(_path + _fileName))
            {
                while (sr.Peek() > -1)
                {
                    string line = sr.ReadLine();
                    if (line.StartsWith('T'))
                    {
                        TV myTv = new TV(line);
                        _item.Add(myTv);
                    }
                    else if (line.StartsWith('C'))
                    {
                        Computer c = new Computer(line);
                        _item.Add(c);
                    }
                    else if (line.StartsWith('F'))
                    {
                        Fruit f = new Fruit(line);
                        _item.Add(f);
                    }
                }
            }
        }
    }
}
