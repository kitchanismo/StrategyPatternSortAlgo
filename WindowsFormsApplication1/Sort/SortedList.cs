using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class SortedList
    {
        private List<string> _list { get; set; }

        private ISort _sort { get; set; }

        public SortedList(ISort sort)
        {
            this._list = new List<string> { };
            this._sort = sort;
        }

        public void AddList(List<string> list)
        {
            this._list = list;
        }

        public void Add(string str)
        {
            this._list.Add(str);
        }

        public void Sort()
        {
            this._sort.Sort(_list);
        }

        public string SortedString()
        {
            var temp = "";
            foreach (var i in _list)
            {
                temp += i.ToString();
            }
            return temp;
        }

    }
}
