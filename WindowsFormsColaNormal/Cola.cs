using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsColaNormal
{
    internal class Cola
    {
        private int primero, ultimo, maxcola;
        private int[] contenedorcola;
        public Cola(int maxcola)
        {
            this.primero = 0;
            this.ultimo = -1;
            this.maxcola = maxcola;
            this.contenedorcola = new int[maxcola];
        }
        public bool colavacia()
        {
            if (this.ultimo < this.primero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool colallena()
        {
            if (this.ultimo == maxcola - 1 && this.primero == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void insertarItem(int dato)
        {
            if (this.colallena())
            {
                MessageBox.Show(" LA COLA ESTA LLENA");
            }
            else
            {
                this.ultimo++;
                this.contenedorcola[ultimo] = dato;
                MessageBox.Show("SE INSERTO CON EXITO A LA COLA");
            }
        }
        public void eliminarItem()
        {
            if (colavacia())
            {
                MessageBox.Show("LA COLA ESTA VACIA");
            }
            else
            {
                MessageBox.Show("SE ELEIMINO CON EXITO EL ELEMENTO " + this.contenedorcola[primero]);

                for (int i = 0; i < this.ultimo; i++)
                {
                    this.contenedorcola[i] = this.contenedorcola[i + 1];
                }
                this.contenedorcola[this.ultimo] = 0;
                this.ultimo--;
            }
        }
        public void VaciarCola()
        {
            if (this.colavacia())
            {
                MessageBox.Show("COLA VACIA");
            }
            else
            {
                for (int i = 0; i <= this.ultimo; i++)
                {
                    this.contenedorcola[i] = 0;
                }
                this.primero = 0;
                this.ultimo = -1;
            }
        }
        public int[] ElementosCola()
        {
            /*if (this.colavacia())
            {
                MessageBox.Show("LA COLA ESTA VACIA");
            }
            else
            {
                lista.Items.Clear();
                for (int i = this.primero; i <= this.ultimo; i++)
                {
                    lista.Items.Add("[" + i + "] => " + this.contenedorcola[i]);
                    
                }
            }*/
            return this.contenedorcola;
        }
        public void Elementos(ListBox lista)
        {
            lista.Items.Clear();
            if (this.colavacia())
            {
                MessageBox.Show("LA COLA ESTA VACIA");
            }
            else
            {
                
                for (int i = 0; i <= this.ultimo; i++)
                {
                    lista.Items.Add("[" + i + "] => " + this.contenedorcola[i]);

                }
            }

        }
    }
}
