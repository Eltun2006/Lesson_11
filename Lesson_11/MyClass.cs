using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    public class MyClass
    {
        public string str_ { get; set; }
        public MyClass(string str)
        {
            str_ = str;
        }
        public void Space(string str)
        {
            foreach(char s in str)
            {
                if(s == str[str.Length-1])
                    Console.WriteLine(s);
                else
                    Console.Write(s + "_");
            }
            Console.WriteLine("\n");
        }

        public void Reverse(string str)
        {
            string newString = "";
            int length = str.Length;

            for (int i = 0; i < str.Length; i++)
            {
                newString += str[length-1];
                length--;
            }
            Console.WriteLine(newString);
        }
    }
}
