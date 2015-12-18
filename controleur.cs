using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLourde_PPE4
{
    class controleur
    {
        private static modele vmodele;
    
            #region accesseur
            public static modele Vmodele
            {
                get { return controleur.vmodele; }
                set { controleur.vmodele = value; }
            }
            #endregion  
 
            public static void init()
            {
                vmodele = new modele();
            }
    }
}
