using System;
using System.Collections.Generic;
using System.Text;

namespace zoo_management_system
{
     class Tiger : Animal
    {

        public override void Speak()
        {
            Console.WriteLine("roarrrrr! ");
        }
            public Tiger() : base()
        {

            }
        public override void ViewInfo()
        {
            base.ViewInfo();
        }
        public Tiger(string Name, int Age, string Description) : base(Name, Age, Description)
        {
        }
    }
}
