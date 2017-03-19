using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort<T>
    {
        private static IComparable<T>[] aux;

        public static void Sort(IComparable<T>[] a)
        {
            aux = new IComparable<T>[a.Length];
            Sort(a, 0, a.Length - 1);
        }

        private static void Sort(IComparable<T>[] a, int lo, int hi)
        {
            if (hi <= lo)
                return;
            int mid = lo + (hi - lo) / 2;
            Sort(a, lo, mid);
            Sort(a, mid + 1, hi);
            merge(a, lo, mid, hi);
        }

        private static void merge(IComparable<T>[] a, int lo, int mid, int hi)
        {
            int i = lo;
            int j = mid + 1;

            //Copy main array to storage array for comparison and manipulation
            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }
            //Manipulate data
            for(int k = lo; k <= hi; k++)
            {
                if (i > mid)
                { a[k] = aux[j++]; }
                else
                {   if(j > hi)
                    { a[k] = aux[i++]; }
                    else
                    {
                        if (aux[j].CompareTo((T)aux[i]) < 0)
                        { a[k] = aux[j++]; }
                        else
                            a[k] = aux[i++];
                    }
                }
            }
        }
    }
}
