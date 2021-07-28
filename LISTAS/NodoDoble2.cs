using System;
using System.Collections.Generic;
using System.Text;

namespace LISTAS
{
    class NodoDoble2
    {
        private int informacion2;
        private NodoDoble2 enlaceIzquierdo2;
        private NodoDoble2 enlaceDerecho2;

        public int Informacion2
        {
            get { return informacion2; }
            set { informacion2 = value; }
        }
        public NodoDoble2 EnlaceIzquierdo2
        {
            get { return enlaceIzquierdo2; }
            set { enlaceIzquierdo2 = value; }
        }

        public NodoDoble2 EnlaceDerecho2
        {
            get { return enlaceDerecho2; }
            set { enlaceDerecho2 = value; }
        }
    }
}

