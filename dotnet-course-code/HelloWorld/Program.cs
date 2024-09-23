using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Startup Message
            // Console.WriteLine("Hello World!");

            //// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
            //// Each bit can be worth 0 or 1 of the value it is placed in
            ////// From the right we start with a value of 1 and double for each digit to the left
            // //// 00000000 = 0
            // //// 00000001 = 1
            // //// 00000010 = 2    
            // //// 00000011 = 3
            // //// 00000100 = 4
            // //// 00000101 = 5
            // //// 00000110 = 6
            // //// 00000111 = 7
            // //// 00001000 = 8
 
            //// 1 byte (8 bit) unsigned, where signed means it can be negative
            // byte myByte = 255;
            // byte mySecondByte = 0;
 
            //// 1 byte (8 bit) signed, where signed means it can be negative
            // sbyte mySbyte = 127;
            // sbyte mySecondSbyte = -128;
 
            //// 2 byte (16 bit) unsigned, where signed means it can be negative
            // ushort myUshort = 65535;
 
            //// 2 byte (16 bit) signed, where signed means it can be negative
            // short myShort = -32768;
 
            //// 4 byte (32 bit) signed, where signed means it can be negative
            // int myInt = 2147483647;
            // int mySecondInt = -2147483648;
 
            //// 8 byte (64 bit) signed, where signed means it can be negative
            // long myLong = -9223372036854775808;
 
            //// 4 byte (32 bit) floating point number
            // float myFloat = 0.751f;
            // float mySecondFloat = 0.75f;
 
            //// 8 byte (64 bit) floating point number
            // double myDouble = 0.751;
            // double mySecondDouble = 0.75d;
 
            //// 16 byte (128 bit) floating point number
            // decimal myDecimal = 0.751m;
            // decimal mySecondDecimal = 0.75m;
 
            // Console.WriteLine(myFloat - mySecondFloat);
            // Console.WriteLine(myDouble - mySecondDouble);
            // Console.WriteLine(myDecimal - mySecondDecimal);
 
            // string myString = "Hello World";
            // Console.WriteLine(myString);
            // string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            // Console.WriteLine(myStringWithSymbols);
 
            // bool myBool = true;

            //// Arrays you cannot add new items with this
            // string[] myGroceryArray = new string[2];
            // myGroceryArray[0] = "Guacamole";
            // myGroceryArray[1] = "Ice Cream";
            // Console.WriteLine(myGroceryArray[0]);
            // Console.WriteLine(myGroceryArray[1]);

            // string[] mySecondGroceryArray = ["Apples", "Eggs"];
            // Console.WriteLine(mySecondGroceryArray[0]);
            // Console.WriteLine(mySecondGroceryArray[1]);

            //// List is like an array that can be changed and add items
            // List<string> myGroceryList = new List<string>() { "Milk", "Cheese"};
            // Console.WriteLine(myGroceryList[0]);
            // Console.WriteLine(myGroceryList[1]);
            // myGroceryList.Add("Butter");
            // Console.WriteLine(myGroceryList[2]);

            //// Ienumerable faster for looping throughs (Cannot manipulate the content as well(cannot add new items etc.) same as array: Also not indexable like 0 1 2 ....)
            // IEnumerable<string> myGroceryIEnumerable = myGroceryList;
            // Console.WriteLine(myGroceryIEnumerable.First());

            //// 2 Dimensional Array
            //// When accessing it is like 0,0 - Apples | 0,1 - Eggs | 1,0 - Milk | 1,1 - Cheese
            // string [,] myTwoDimensionalArray = new string[,] {
            //     { "Apples", "Eggs" },
            //     { "Milk", "Cheese" },
            // }; 
            // Console.WriteLine(myTwoDimensionalArray[0,0]);

            //// Dictionary always need key and value.
            // Dictionary<string, string> myGroceryDictionary = new Dictionary<string, string> () {
            //     { "Cheese", "Dairy" }
            // };
            // Console.WriteLine(myGroceryDictionary["Cheese"]);

            // Dictionary<string, string[]> myGroceryDictionaryTwo = new Dictionary<string, string[]> () {
            //     { "Dairy", new string[]{ "Cheese", "Milk", "Eggs" }}
            // };
            // Console.WriteLine(myGroceryDictionary["Cheese"]);
            // Console.WriteLine(myGroceryDictionaryTwo["Dairy"][0]);

            // Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>() {
            //     { "cheese", 5.99m },
            //     { "carrots", 2.99m },
            // };

            // Console.WriteLine(itemPrices["cheese"].GetType());
            // Console.WriteLine(itemPrices["cheese"]);
            // Console.WriteLine(itemPrices["carrots"]);


            //// Operators and Conditionals 
            // int myInt = 5;
            // myInt++; // 6 - ++ increments integer value by 1
            // myInt += 6; // 12 - += increments integer value by 6 or the intger value that is passed in.
            // myInt -= 2; // 10 - -= decrements integer value by 2 or the intger value that is passed in.s
            // Console.WriteLine(myInt);

            // int mySecondInt = 5;
            // Console.WriteLine(myInt + mySecondInt);
            // Console.WriteLine(myInt - mySecondInt);
            // Console.WriteLine(myInt * mySecondInt);
            // Console.WriteLine(myInt / mySecondInt);
            // Console.WriteLine(myInt % mySecondInt);
            // Console.WriteLine(myInt.Equals(10)); // You can also perform operation like 5 + 5 etc inside the Equals
            // Console.WriteLine(myInt == 10);
            // Console.WriteLine(myInt != 10);
            // Console.WriteLine(myInt > 10);
            // Console.WriteLine(myInt < 10);
            // Console.WriteLine(myInt >= 10);
            // Console.WriteLine(myInt <= 10);
            // Console.WriteLine(myInt >= 10 && myInt <= 10);
            // Console.WriteLine(myInt >= 10 || myInt <= 5);

            //// C# Follows MDAS in Multiplication Division Addition Subtraction
            
            // Console.WriteLine(Math.Pow(5, 2));
            // Console.WriteLine(Math.Sqrt(25));

            // string myString = "Hello World";
            // myString += ". Goodbye World.";
            // myString = myString + " \"Third World\\ Departure.";
            // Console.WriteLine(myString);

            // string[] myStringArr = myString.Split(". ");
            // Console.WriteLine(myStringArr[0]);
            // Console.WriteLine(myStringArr[1]);
            // Console.WriteLine(myStringArr[2]);
        }
    }
}