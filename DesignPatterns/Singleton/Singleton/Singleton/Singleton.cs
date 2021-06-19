using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public string TestText { get; set; }
        
        private Singleton() { TestText = "Nothing Set"; }

        public static Singleton Instance
        {
            get{ return instance ??= new Singleton(); }
        }

    }
}
