using System;
using System.Collections.Generic;
using System.Text;

namespace LISTAS
{
    class ListaSimplementeEnlazada
    {

        public Nodo tope = null;
        public Nodo2 tope2 = null;
        public void Insertar_1(int info)
        {
         

            Nodo p, q, r;

            if (tope == null)
            {
                tope = new Nodo();
                tope.Info = info;

                tope.Enlace = null;
        

            }
            else
            {
                if (info < tope.Info)
                {
                    p = new Nodo();
                    p.Info = info;

                    p.Enlace = tope;
                    tope = p;



                }
                else
                {
                    //
                    r = tope;
                    q = tope.Enlace;
                    while (q != null && info > q.Info)
                    {
                        r = q;
                        q = q.Enlace;
                    }
                    if (q != null)
                    {
                        p = new Nodo();
                        p.Info = info;

                        r.Enlace = p;
                        p.Enlace = q;
 

                    }
                    else
                    {
                        p = new Nodo();
                        p.Info = info;

                        p.Enlace = null;
                        r.Enlace = p;



                    }
                }

            }
        }

        public void Insertar_2(int info)
        {


            Nodo2 p, q, r;

            if (tope2 == null)
            {
                tope2 = new Nodo2();
                tope2.Info2 = info;

                tope2.Enlace2 = null;


            }
            else
            {
                if (info < tope2.Info2)
                {
                    p = new Nodo2();
                    p.Info2 = info;

                    p.Enlace2 = tope2;
                    tope2 = p;



                }
                else
                {
                    //
                    r = tope2;
                    q = tope2.Enlace2;
                    while (q != null && info > q.Info2)
                    {
                        r = q;
                        q = q.Enlace2;
                    }
                    if (q != null)
                    {
                        p = new Nodo2();
                        p.Info2 = info;

                        r.Enlace2 = p;
                        p.Enlace2 = q;


                    }
                    else
                    {
                        p = new Nodo2();
                        p.Info2 = info;

                        p.Enlace2 = null;
                        r.Enlace2 = p;



                    }
                }

            }
        }
    }
}

