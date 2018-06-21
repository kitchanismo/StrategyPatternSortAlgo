using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{

    class QuickSort : ISort
    {
        private List<string> _list;

        private int Partition(int L, int U)
        {
            int s = U;
            int p = L;
            while (s != p)
            {
                if (_list[p].CompareTo(_list[s]) <= 0)
                {
                    p++;
                }
                else
                {
                    Swap(p, s);
                    Swap(p, s - 1);
                    s--;
                }
            }
            return p;
        }

        private void Swap(int p, int s)
        {
            var temp = _list[p];
            _list[p] = _list[s];
            _list[s] = temp;
          
        }

        private void Sorting(int L, int U)
        {
            if (L >= U) return;
            int p = Partition(L, U);
            Sorting(L, p - 1);
            Sorting(p + 1, U);
           
        }

        public void Sort(List<string> list)
        {
            _list = list;
            Sorting(0, _list.Count - 1);
        }
    }
}