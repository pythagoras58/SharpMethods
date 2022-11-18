using System;

namespace SharpMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstVal = 23;
            int secondVal = 23432;
            AddThem(firstVal, secondVal);

            int res = getSub(secondVal, firstVal);
            Console.WriteLine($"DIVISION --> {res}");

            Card card = new Card();
            card.face = "My Face";
            card.suit = "Blue";

            Console.WriteLine(card.face.ToString());
        }

        static int AddThem(int a, int b)
        {
            Console.WriteLine($"SUMMATION VALUE IS : {(a + b)}");
            return a + b;
        }

        static int getSub(int a, int b)
        {
            return a - b;
        }
    }

    class Card
    {
        public string face;
        public string suit;
    }
}
