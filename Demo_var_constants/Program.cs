using System;

namespace Demo_var_constants
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;  //must use the f after the number for float
            char character = 'A'; //single quotes for char
            string firstName = "Amy"; //double quotes for string
            bool isWorking = false; //all blue words are key words

            //could replace above with var instead and let the compiler detect the data type
            var num = 2;
            var counting = 10;
            var Price = 20.95f;  //remember the f
            var chara = 'A';
            var name = "Amy";
            var working = false;


            Console.WriteLine(number);
            Console.WriteLine(count);//code snippet for this is cw tab twice (really cool)
            Console.WriteLine(totalPrice); //remember cw tab twice
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            
            //printing the var (produced the same results
            Console.WriteLine(num);
            Console.WriteLine(counting);
            Console.WriteLine(Price);
            Console.WriteLine(chara);
            Console.WriteLine(name);
            Console.WriteLine(working);
        }
    }
}
