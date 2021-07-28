using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTAS
{
    public partial class Form1 : Form
    {
        ListasDoblementeEnlazadas lde = new ListasDoblementeEnlazadas(); 
       

        void MostrarLDE()
        {
            NodoDoble p;
            listView1.Clear();
            p = lde.primero;
            while (p != null)
            {
                listView1.Items.Add(p.Informacion.ToString());
                p = p.EnlaceDerecho;
            }
        }

        void MostrarLDE2()
        {
            NodoDoble2 z;
            listView2.Clear();
            z = lde.primero2;
            while (z != null)
            {
                listView2.Items.Add(z.Informacion2.ToString());
                z = z.EnlaceDerecho2;
            }
        }

        void MostrarLDE3()
        {
       
            NodoDoble p;
            NodoDoble2 z;

            listView3.Clear();
           
            p = lde.primero;
            z = lde.primero2;

            while (p!=null)
            {
              
                listView3.Items.Add(p.Informacion.ToString());
                
                p = p.EnlaceDerecho;
            }

            while (z != null)
            {

                listView3.Items.Add(z.Informacion2.ToString());

                z = z.EnlaceDerecho2;
            }

        }




        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnIsertar_Click(object sender, EventArgs e)
        {
            lde.Insertar_1(Int32.Parse(txtElementos.Text));

            MostrarLDE();
            MostrarLDE3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lde.Insertar_2(Int32.Parse(txtElementos2.Text));

            MostrarLDE2();
            MostrarLDE3();
        }



        private void txtElementos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        
        }


    }
}
