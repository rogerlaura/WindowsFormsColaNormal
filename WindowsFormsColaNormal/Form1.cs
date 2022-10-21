using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsColaNormal
{
    public partial class Form1 : Form
    {
        Cola cola;
        public Form1()
        {
            cola = new Cola(4);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtdato.Text);
            cola.insertarItem(dato);
            cola.Elementos(listacola);
            txtdato.Text = "";
        }
        public void Listar()
        {
           
            listacola.Items.Clear();
            int[] elementos = cola.ElementosCola();
            for (int i=0; i< elementos.Length; i++)
            {
                listacola.Items.Add(elementos[i]);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            cola.eliminarItem();
            cola.Elementos(listacola);
        }

        private void btnvaciar_Click(object sender, EventArgs e)
        {
            cola.VaciarCola();
            cola.Elementos(listacola);
        }
    }
}
