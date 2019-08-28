using System;
using System.Collections.Generic;

namespace Inheritance
{
    internal class Stack
    {
        private readonly List<object> _objects = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw (new InvalidOperationException("Cannot add null reference to stack!"));
            _objects.Add(obj);
        }

        public object Pop()
        {
            if (_objects.Count < 1)
                throw (new InvalidOperationException("Stack is empty!"));
            var temp = _objects[_objects.Count - 1];
            _objects.Remove(temp);
            return temp;
        }

        public void Clear()
        {
            _objects.Clear();
        }
    }
}