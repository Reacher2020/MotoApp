﻿namespace MotoApp
{
    internal class BasicStack<T>
    {
        private readonly T[] _item;

        private int _currentIndex = -1;

        public BasicStack() => _item = new T[10];
        
        public int Count() => _currentIndex + 1;

        public void Push(T item) => _item[++_currentIndex] = item;

        public T Pop() => _item[_currentIndex--];
    }
}
