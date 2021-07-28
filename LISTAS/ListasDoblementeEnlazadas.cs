using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LISTAS
{
    class ListasDoblementeEnlazadas
    {
        public NodoDoble primero;
        public NodoDoble ultimo;

        public NodoDoble2 primero2;
        public NodoDoble2 ultimo2;


        public bool vacia()
        {
            if (primero == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool vacia2()
        {
            if (primero2 == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insertar_1(int x)
        {
            NodoDoble p;
            if (vacia())
            {
                primero = new NodoDoble();
                primero.Informacion = x;

                primero.EnlaceDerecho = null;
                primero.EnlaceIzquierdo = null;

                ultimo = primero;
            
            }
            else
            {
                p = new NodoDoble();
                p.Informacion = x;

                p.EnlaceDerecho = null;
                p.EnlaceIzquierdo = ultimo;

                ultimo.EnlaceDerecho = p;
                ultimo = p;
    
            }

        }

        public void Insertar_2(int y)
        {
            NodoDoble2 z;
            if (vacia2())
            {
                primero2 = new NodoDoble2();
                primero2.Informacion2 = y;

                primero2.EnlaceDerecho2 = null;
                primero2.EnlaceIzquierdo2 = null;

                ultimo2 = primero2;
                //primero = ultimo;
            }
            else
            {
                z = new NodoDoble2();
                z.Informacion2 = y;

                z.EnlaceDerecho2 = null;
                z.EnlaceIzquierdo2 = ultimo2;

                ultimo2.EnlaceDerecho2 = z;
                ultimo2 = z;
                // z =ultimo;
            }

        }
    }
}
