using System;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Model m = new Model();
            View v = new View();
            Controller c = new Controller(m,v);

            c.ChangeModelData();
            c.ChangeModelDataToUpper();
        }
    }
}
