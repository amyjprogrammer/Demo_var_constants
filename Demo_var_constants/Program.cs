﻿using System;
using System.Collections;

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
            Console.WriteLine(t % 3);//will be 1, because that is the remainder after dividing the numbers

            int num1 = 10;
            num1 += 100;// also -=, /=, *=
            Console.WriteLine(num);//will be 110

            num1++;
            Console.WriteLine(num1);//add the 1 so the value is 111

            //Comments :)
            // if single line is //
            /*
             Multi-line comment
            */

            //Casting
            Console.WriteLine((int)3.14);// shows as 3 and will convert to int
            Console.WriteLine((double)3);//also 3, but will now be a double

            int intFromString = Convert.ToInt32("50"); //from string to int
            double doubleFromString = Convert.ToDouble("50.99"); //from string to double

            Console.WriteLine(100 + intFromString); // is 150
            Console.WriteLine(100 + doubleFromString);//is 150.99

            //Strings

            string greeting = "Hello"; //indexes of 01234, starts from 0

            Console.WriteLine(greeting.Length);// shows 5
            Console.WriteLine(greeting[0]); // H
            Console.WriteLine(greeting.IndexOf("llo")); //2, because it starts at index 2
            Console.WriteLine(greeting.IndexOf("z"));//-1, because not found in the string
            Console.WriteLine(greeting.Substring(2));//ll0, starts at index 2 to the end
            Console.WriteLine(greeting.Substring(1, 3));//ell, starts at index 1 and stops at index 3

            //Math Method
            Console.WriteLine(Math.Pow(2, 3));//2 to the power of 3 which is 8
            Console.WriteLine(Math.Sqrt(144));//square root of 144 is 12
            Console.WriteLine(Math.Round(2.7));//rounding the number which is 3

            //Arrays

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            luckyNumbers[0] = 90; //changes the 4 to 90;
            Console.WriteLine(luckyNumbers[0]); //90
            Console.WriteLine(luckyNumbers[1]); //8
            Console.WriteLine(luckyNumbers.Length);//6

            int[] luckyNum = new int[10]; //specifies the length of the array, but doesn't add any values
            luckyNum[0] = 90; //adds 90 as the first in the array
            Console.WriteLine(luckyNum[0]);//90
            Console.WriteLine(luckyNum[1]);//no second number listed so the value is 0
            Console.WriteLine(luckyNum.Length);//10, because that is the length specified when it was initialized

            //multiple dimensional arrays
            int[][] numberGrid = { new int[] { 1, 2 }, new int[] { 3, 4 } };
            numberGrid[0][1] = 99; //replacing the 2 above

            Console.WriteLine(numberGrid[0][1]);//99 as shown above
            Console.WriteLine(numberGrid[0][0]);//1, because it is the first new int and the firt number in new int

            //Array List
            //had to add using System.Collections above to use this
            ArrayList friends = new ArrayList();
            friends.Add("Oscar");
            friends.Add("Angela");
            friends.Add("Kevin");

            Console.WriteLine(friends[0]);//Oscar
            Console.WriteLine(friends[1]);//Angela
            Console.WriteLine(friends.Contains("Oscar"));//True
            Console.WriteLine(friends.Count);//3

            friends.Remove("Oscar");//removes Oscar from the Array List
            Console.WriteLine(friends.Count);//now it is 2


        }
    }
}
