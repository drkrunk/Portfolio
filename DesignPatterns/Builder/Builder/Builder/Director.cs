using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //Director dictates the object being built based on it's builder then constructs the object.
    class Director
    {
        //The way the object should be built.
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        //Returns the object.
        public Class1 GetObject() {

            return this.builder.GetObject();
        }

        //Builds the object.
        public void MakeObject() {

            this.builder.BuildPartA();
            this.builder.BuildPartB();
            this.builder.BuildPartC();

        }
    }
}
