using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyFruitEnum myFruit = MyFruitEnum.Orange;
            var myFruitFound = myFruit.In(MyFruitEnum.Orange, MyFruitEnum.Banana);

            string myString = "qux";
            var myStringFound = myString.In("foo", "bar", "baz", "qux");

            int myInt = 9;
            var indexOfMyInt = myInt.Pos(3, 8, 11, 9);

            char myChar = 'y';
            var indexOfMyChar = myChar.Pos('x', 'y', 'z');
        }



    }
}
