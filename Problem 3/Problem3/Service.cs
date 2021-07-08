using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Service
    {
        public Service()
        {
        }

        public int PickingNumbers(List<int> a)
        {
            Dictionary<int, int> funcDict = new Dictionary<int, int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (funcDict.ContainsKey(a[i]))
                {
                    var val = funcDict[a[i]];
                    funcDict.Remove(a[i]);
                    funcDict.Add(a[i], val + 1);
                }
                else
                {
                    funcDict.Add(a[i], 1);
                }
            }

            int max = 0;

            foreach (KeyValuePair<int, int> item in funcDict)
            {
                if (funcDict.ContainsKey(item.Key + 1))
                    max = Math.Max(max, funcDict[item.Key] + funcDict[item.Key + 1]);
            }

            if(max > 5)
            {
                max = 5;
            }

            return max;

        }
    }
}
