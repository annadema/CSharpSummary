using System;
using System.Collections.Generic;

namespace StackExercise
{
    public class Stack
    {
        private readonly List<object> _stack  = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("null can't be added to stack");
            _stack.Add(obj);
        }
        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("Stack empty");

            var index = _stack.Count - 1;

            var itemToRemove = _stack[index];

            _stack.RemoveAt(index);

            return itemToRemove;
        }
        public void Clear()
        {
            _stack.Clear();
            Console.WriteLine("Stack cleared  {0}", _stack.Count);
        }
    }
}