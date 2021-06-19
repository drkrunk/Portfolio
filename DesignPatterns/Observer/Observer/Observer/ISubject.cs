﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface ISubject
    {
        public void Register(IObserver observer);

        public void Unregister(IObserver observer);

        public void Notify();

    }
}
