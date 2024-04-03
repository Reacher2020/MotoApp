using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp
{
    internal class BasicStack
    {
        private readonly double[] _item;

        private int _currentIndex = -1;

        public BasicStack() => _item = new double[10];
        
        public int Count = _currentIndex + 1;

        public void Push(double item) => _item[++ _currentIndex] = item;

        public double Pop() => _item[_currentIndex--];
    }
}
