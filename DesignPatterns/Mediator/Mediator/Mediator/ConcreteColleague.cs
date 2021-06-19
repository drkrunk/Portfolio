using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class ConcreteColleague : Colleague
    {
        public ConcreteColleague(IMediator mediator) :base(mediator)
        {

        }
    }
}
