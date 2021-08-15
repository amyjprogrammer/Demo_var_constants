﻿using System;

namespace Demo_var_constants
{
    //to run the program use ctrl f5
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
            var working = false;  //use control click when on top of var to get info about it


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

            //0- first arg (byte.MinValue) 1- second arg (byte.MaxValue)
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // use ctrl x to delete a line
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // constant with const key word
            const float Pi = 3.14f;

            //Type Conversion

            byte b = 1; //only takes one byte
            int i = b; //int takes four and a byte can be converted, because of no data loss
            Console.WriteLine(i);

            int r = 1;
            // couldn't use byte y = r; 
            byte y = (byte) r;
            Console.WriteLine(y);

            //converting non-compatible types
            string convertNumber = "1234";
            int numb = Convert.ToInt32(convertNumber);
            Console.WriteLine(numb);

            //type try and tab twice 
            try
            {
                var byteNum = "1234";
                byte bn = Convert.ToByte(byteNum); //byte is not larger enough and will crash the system
                Console.WriteLine(bn);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
              
            }

            try
            {
                string strTrue = "true";
                bool tf = Convert.ToBoolean(strTrue);
                Console.WriteLine(tf);
            }
            catch (Exception)
            {
                Console.WriteLine("This couldn't be converted to a True or False");                
            }

            //difference of prefix increment or post fix increment
            int a = 1;
            int c = a++;
            Console.WriteLine(c); //c is one, because it is a post fix
            Console.WriteLine(a);// a is two

            //prefix demo
            int h = 1;
            int j = ++h;
            Console.WriteLine(h);// both are now two, because the ++ are before 
            Console.WriteLine(j);

            //Operators

            var t = 10;
            var s = 3;
            var u = 2;
            Console.WriteLine(s + t); //comes out to 13
            Console.WriteLine(t / s);// comes out to 3, becuase they are both integers
            Console.WriteLine((float)t / (float)s);// comes out to 3.33333
            Console.WriteLine(t + s * u);//comes out to 16
            Console.WriteLine((t + s) * u);//comes out to 26
            Console.WriteLine(t > s); //comes out as a boolean value- true
            Console.WriteLine(t == s);// also comes out as a boolean value- false
            Console.WriteLine(t != s);//also bool value- true
            Console.WriteLine(t > s && t > u);//&& operator (both must be true to be true)
            Console.WriteLine(t > s || t < u);// || operator (one must be true to be true)

            //Comments :)
            // if single line is //
            /*
             Multi-line comment
            */ 

        }
    }
}
