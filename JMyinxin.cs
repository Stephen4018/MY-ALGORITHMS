﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MY_ALGORITHMS
{
    public class JMyinxin
    {
        //     A little boy is studying arithmetics.He has just learned how to add two integers, written one below another, column by column.But he always forgets about the important part - carrying.
        //     Given two integers, find the result which the little boy will get.
        //     Example
        //     For param1 = 456 and param2 = 1734, the output should be 1180

        // 456 //1734 // + ____  //1180

        public int AdditionWithoutCarrying(int a, int b)
        {
            char[] word1 = a.ToString().ToCharArray();
            char[] word2 = b.ToString().ToCharArray();

            Array.Reverse(word1);
            Array.Reverse(word2);
            int len = Math.Max(a,b).ToString().Length;

            for (int i = 0; i < len; i++)
            {
                
            }

            return 0;


        }

    }
}
