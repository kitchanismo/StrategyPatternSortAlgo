using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Factory
    {
        private Dictionary<string, ISort> sort = new Dictionary<string, ISort> { };
        
        public Factory()
        {
            if(sort.Count == 0)
            {
                sort.Add("bubble sort", new BubbleSort());
                sort.Add("quick sort", new QuickSort());
            }
        }

        public ISort Make(string strategy)
        {
            return sort[strategy];
        }

    }
}
