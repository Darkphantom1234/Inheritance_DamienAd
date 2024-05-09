using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_DamienAd
{
     class FPS : Game
     {

        public FPS(string esrbparam, string titleparam) : base(esrbparam, titleparam)
        {
         Title = titleparam;
         Esrb = esrbparam;
        }

        public override string Describe()
        {
            return $"(Title) is a fps game rated {Esrb}!";
        }

      
    }
}
