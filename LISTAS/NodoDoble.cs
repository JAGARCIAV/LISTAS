using System;
using System.Collections.Generic;
using System.Text;

namespace LISTAS
{
    class NodoDoble
    {
        private int informacion;
        private NodoDoble enlaceIzquierdo;
        private NodoDoble enlaceDerecho;

        public int Informacion
        {
            get { return informacion; }
            set { informacion = value; }
        }
        public NodoDoble EnlaceIzquierdo
        {
            get { return enlaceIzquierdo; }
            set { enlaceIzquierdo = value; }
        }

        public NodoDoble EnlaceDerecho
        {
            get { return enlaceDerecho; }
            set { enlaceDerecho = value; }
        }
    }
}

