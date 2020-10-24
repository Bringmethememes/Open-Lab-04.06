using System.Linq;
using NUnit.Framework;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;


namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            var pleb = new List<int>();
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    
                }
                else
                {
                    pleb.Add(numbers[i]);
                }
            }
            return pleb.ToArray();



        }     
    } 
}
