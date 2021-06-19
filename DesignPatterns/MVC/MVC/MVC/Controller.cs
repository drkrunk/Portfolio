using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    class Controller
    {
        private Model model;
        private View view;

        public Controller(Model model ,View view)
        {
            this.model = model;
            this.view = view;

            view.DisplayIntro();
        }

        public void ChangeModelData() {
            model.ModelData = this.view.GetUserInput();
            view.DisplayInfo(model.ModelData);
        }

        public void ChangeModelDataToUpper()
        {
            model.ToUpper(); ;
            view.DisplayInfo(model.ModelData);
        }

    }
}
