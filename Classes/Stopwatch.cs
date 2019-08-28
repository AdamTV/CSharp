using System;
using System.Collections.Generic;

namespace Classes
{
    internal class Stopwatch
    {
        private bool _hasStarted;
        private DateTime _start, _stop;
        private TimeSpan _timeSpan;

        public Stopwatch()
        {
            _hasStarted = false;
        }
        public void Start()
        {
            if (!_hasStarted)
            {
                _start = DateTime.Now;
            }
            else
            {
                throw (new InvalidOperationException("Cannot start stopwatch twice!"));
            }
            _hasStarted = true;
        }
        public void Stop()
        {
            if (_hasStarted)
            {
                _stop = DateTime.Now;
                _timeSpan += (_stop - _start);
            }
            else
            {
                throw(new InvalidOperationException("Stopwatch must be started before stopping"));
            }
            _hasStarted = false;
            Console.WriteLine($"Total calculated timespan: {_timeSpan}");
        }
    }
}