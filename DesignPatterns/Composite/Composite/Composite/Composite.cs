using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Composite : IComponents
    {
        //List of Components
        private List<IComponents> list = new List<IComponents>();

        public void Add(IComponents component) { list.Add(component); }
        
        public void Remove(IComponents component) { list.Remove(component); }

        //Does action of each leaf.
        public void Action()
        {
            foreach (IComponents coms in list)
            {
                coms.Action();
            }
        }
    }
}
