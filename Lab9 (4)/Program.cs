using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 100000;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            N = (int)(Math.Pow(N, 0.33));
            Console.WriteLine(N);
            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    for (int z = 0; z < N; z++)
                    {
                        int sum = (int)(Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3));
                        dictionary.Add(x + "+" + y + "+" + z, sum);
                    }
                }
            }
            int[] combinations = new int[100001];
            foreach (KeyValuePair<string, int> match in dictionary)
            {
                if (match.Value < 100001)
                {
                    combinations[match.Value]++;
                }
            }
            for (int i = 0; i < 100001; i++)
            {
                if (combinations[i] >= 2)
                {
                   Console.WriteLine(i);
                }
            }

            
        }
    }
}
