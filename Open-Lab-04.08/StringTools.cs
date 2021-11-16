using System;
using System.Collections;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            var vs = new List<string>();


            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 4)
                {
                    vs.Add(strings[i]);
                }
            }
            string[] answer = vs.ToArray();
            return answer;
        }
    }
}
