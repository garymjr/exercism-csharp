using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var count = 0;
        foreach (var multiple in multiples)
        {
            for (int i = 1; i < max; i++)
            {
                if (multiple % i == 0)
                {
                    count += 1;
                }
            }
        }

        return count;
    }
}
