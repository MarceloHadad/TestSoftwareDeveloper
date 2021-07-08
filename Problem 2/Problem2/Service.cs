using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Service
    {
        public Service()
        {
        }

        public int[] CircularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] result = a.ToArray();

            for (int i = 0; i < k; i++)
            {
                var aux = result.Last();
                for (int j = result.Length - 1; j > 0; j--)
                {
                    result[j] = result[j - 1];
                }
                result[0] = aux;
            }

            return result;
        }
    }
}
