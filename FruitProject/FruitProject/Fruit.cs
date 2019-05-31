using System;
using System.Collections.Generic;
using System.Text;

namespace FruitProject
{
    public class Fruit
    {
        public string _size { set; get; }

        public string _color { set; get; }


        public Fruit(string size, string color)
        {
            _size = size;
            _color = color;

            Console.WriteLine("Delicious ready-to-eat fruit");
        }

        public void grow(string enlarge)
        {
            Console.WriteLine("Avocados are {0} at first, but they get {1}", _size, enlarge);
        }

    }

    public class Avocado: Fruit
    {
         public bool _hasSeed { set; get; }
         public  Avocado(string size, string color, bool hasSeed) : base(size, color)
        { 
                _size = size;
                _color = color;
                _hasSeed = hasSeed;
        }


        public void ripe(string colorChange)
        {
            Console.WriteLine("Avocados are {0}, but they {1} when ripe", _color, colorChange);
        }

    }

}
    
