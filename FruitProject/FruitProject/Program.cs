using System;

namespace FruitProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Fruit fruta = new Fruit("green","medium");
            fruta.grow("bigger");

            Avocado palta = new Avocado("Medium","Green", true);
            palta.ripe("turn black");     

           
        }
    }
}
