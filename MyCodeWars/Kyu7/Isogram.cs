using System;
using System.Linq;

namespace MyCodeWars
{
    public class Isogram
    {
        /*
        An isogram is a word that has no repeating letters, consecutive or non-consecutive. 
        Implement a function that determines whether a string that contains only letters is an isogram. 
        Assume the empty string is an isogram. Ignore letter case.

        isIsogram "Dermatoglyphics" == true
        isIsogram "moose" == false
        isIsogram "aba" == false
         */
        public static bool IsIsogram(string str) =>
           str.ToLower().GroupBy(s => s).Where(s => s.Count() > 1).Count() == 0;

    }
}