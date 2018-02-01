using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritme_te_Acancuara.D2.P3
{
    public class AlbertoTheAviator
    {
        public static int MaximumFlights(int fMax, int[] duration, int[] refuel)
        {
            int nrMisioneve = duration.Length;
            List<HashSet<int>>[] M = new List<HashSet<int>>[fMax + 1];
            for (var i = 0; i < M.Length; i++)
            {
                M[i] = new List<HashSet<int>>();
            }

            for (int f = 1; f <= fMax; f++)
            {
                for (int i = 0; i < nrMisioneve; i++)
                {
                    if (f < duration[i])
                    {
                        continue;
                    }

                    M[f].Add(new HashSet<int> { i });

                    var afterMission = f - (duration[i] - refuel[i]);
                    for (var j = 1; j <= afterMission; j++)
                    {
                        foreach (var set in M[j])
                        {
                            var newSet = new HashSet<int>(set);
                            newSet.Add(i);
                            if (!M[f].Any(solution => newSet.SetEquals(solution)))
                            {
                                M[f].Add(newSet);
                            }
                        }
                    }
                }
            }

            return M[fMax].Count == 0 ? 0 : M[fMax].Max(x => x.Count);
        }
    }
}
