using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    abstract class Colleague
    {
        private IMediator mediator;

        public Colleague(IMediator mediator) {
            this.mediator = mediator;
        }

    }
}
