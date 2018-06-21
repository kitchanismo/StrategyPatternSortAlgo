using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
     class Helper
    {
   
        public List<string> ToList(string letters)
        {
           
            int length = letters.Length;

            var temp = new List<string>();

            for (int i = 0; i < length; i++)
            {
                temp.Add(letters.Substring(i, 1));
            }

            return temp;
        }

        public string parseString(string[] str = null)
        {
           
            var temp = "";

            for (int i = 0; i < str.Length; i++)
            {
                temp += str[i].ToString();
            }
            return temp;
        }

    }
}
