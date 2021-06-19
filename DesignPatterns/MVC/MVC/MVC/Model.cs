using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    class Model
    {
        public string  ModelData { get; set; }

        public void ToUpper() { ModelData = ModelData.ToUpper(); }
        

    }
}
