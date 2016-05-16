﻿using System;

namespace Flakey
{
    public class MockTimeSource : ITimeSource
    {
        private DateTime _current;

        public MockTimeSource()
            : this(DateTime.UtcNow) { }

        public MockTimeSource(DateTime current)
        {
            _current = current;
        }

        public DateTime GetTime()
        {
            return _current;
        }

        public void NextTick()
        {
            _current = _current.AddMilliseconds(1);
        }

        public void PreviousTick()
        {
            _current = _current.AddMilliseconds(-1);
        }
    }
}
