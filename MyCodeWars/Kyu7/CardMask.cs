using System;
using System.Collections.Generic;

namespace MyCodeWars
{
    public static class CardMask
    {
        /*
        Kata.Maskify('4556364607935616'); // should return "############5616"
        Kata.Maskify('64607935616');      // should return "#######5616"
        Kata.Maskify('1');                // should return "1"
        Kata.Maskify('');                 // should return ""

        // "What was the name of your first pet?"
        Kata.Maskify('Skippy');                                   // should return "##ippy"
        Kata.Maskify('Nananananananananananananananana Batman!'); // should return "####################################man!"
        */

        // return masked string
        public static string Maskify(string cc)
        {
            if (cc == "1" || cc == "") return cc;
            string str = "";

            for (int i = 0; i < cc.Length; i++)
            {
                str += ((i < cc.Length - 4) ? "#" : cc[i].ToString());
            }

            return str;
        }
    }
}