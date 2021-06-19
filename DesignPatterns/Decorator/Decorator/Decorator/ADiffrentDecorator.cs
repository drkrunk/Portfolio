﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ADiffrentDecorator : AbstractDecorator
    {
        public ADiffrentDecorator(IComponent objToBeDecorated):base(objToBeDecorated)
        {
        }

        public override string Print()
        {

            return base.Print() + " | ADiffrentDecorator";
        }
    }
}
