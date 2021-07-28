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
                //primero = ultimo;
            }
            else
            {
                p = new NodoDoble();
                p.Informacion = x;

                p.EnlaceDerecho = null;
                p.EnlaceIzquierdo = ultimo;

                ultimo.EnlaceDerecho = p;
                ultimo = p;
                // p =ultimo;
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

        public void eliminar(int x)
        {
            NodoDoble p, q, r;

            if (vacia())
            {
                MessageBox.Show("Error, la lista esta vacia, no se puede eliminar");

            }
            else
            {
                p = primero;
                while (p != null && p.Informacion != x)
                    p = p.EnlaceDerecho;
                if (p == null)
                {
                    MessageBox.Show("El elemento no se encuentra en la lista");
                }
                else
                {
                    if (p == primero)
                    {
                        if (primero.EnlaceDerecho != null)
                        {
                            primero = primero.EnlaceDerecho;
                            primero.EnlaceIzquierdo = null;
                        }
                        else
                        {
                            primero = null;
                        }
                        p.EnlaceDerecho = null;
                        p.EnlaceIzquierdo = null;
                        p = null;
                    }
                    else
                    {
                        q = p.EnlaceDerecho;
                        r = p.EnlaceIzquierdo;
                        if (q != null)
                        {
                            r.EnlaceDerecho = q;
                            q.EnlaceIzquierdo = r;
                        }
                        else
                        {
                            r.EnlaceDerecho = null;

                        }
                        p.EnlaceDerecho = null;
                        p.EnlaceIzquierdo = null;
                        p = null;
                    }
                }
            }
        }

        public void insertar_ordenadamente_ascendentemente(int x)
        {
            NodoDoble p, q, r;

            if (vacia())
            {
                primero = new NodoDoble();
                primero.Informacion = x;
                primero.EnlaceDerecho = null;
                primero.EnlaceIzquierdo = null;

            }
            else
            {
                if (x < primero.Informacion)
                {
                    p = new NodoDoble();
                    p.Informacion = x;

                    p.EnlaceIzquierdo = null;
                    p.EnlaceDerecho = primero;
                    primero.EnlaceIzquierdo = p;
                    primero = p;
                }
                else
                {
                    r = primero;
                    q = primero.EnlaceDerecho;
                    while (q != null && x > q.Informacion)
                    {
                        r = q;
                        q = q.EnlaceDerecho;
                    }
                    if (q != null)
                    {
                        //izquierda
                        p = new NodoDoble();
                        p.Informacion = x;

                        r.EnlaceDerecho = p;
                        p.EnlaceIzquierdo = r;

                        p.EnlaceDerecho = q;
                        q.EnlaceIzquierdo = p;
                    }
                    else
                    {
                        //derech
                        p = new NodoDoble();
                        p.Informacion = x;

                        p.EnlaceDerecho = null;
                        p.EnlaceIzquierdo = r;
                        r.EnlaceDerecho = p;
                    }
                }
            }
        }

    }
}
