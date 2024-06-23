using System;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _begin;
        private DateTime _end;
        private bool _isrunning;
        public void Start()
        {
            if (_isrunning)
                throw new InvalidOperationException("Already running");

            _begin = DateTime.Now;
            _isrunning = true;

            Console.WriteLine("Started: " + _begin.ToString("T"));
        }
        public void Stop()
        {
            if(!_isrunning)
                throw new InvalidOperationException("not running");

            _end = DateTime.Now;
            _isrunning = false;

            var duration = _end - _begin;
            Console.WriteLine("Time passed: " + duration);
        }
    }
}