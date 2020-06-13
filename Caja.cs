using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PizzaHatApp
{
    public partial class Caja : Form
    {

        List<int> listaTotal = new List<int>();
        public Caja()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int Total = 0;
            string tipoPizza = "";
            string tipoTamaño = "";
            string tipoAgregado = "";
            

            if (buttonItaliana.Checked == true)
            {
                tipoPizza = "Italiana ";
                Total += 650;
            }
            else if (buttonEspañola.Checked == true)
            {
                tipoPizza = "Española ";
                Total += 1350;
            }else if(buttonHawaiiana.Checked == true)
            {
                tipoPizza = "Hawaiiana ";
                Total += 650;
            }

            if (buttonIndividual.Checked == true)
            {
                tipoTamaño = "Individual ";
                Total += 3250;
            }else if(buttonMediana.Checked == true)
            {
                tipoTamaño = "Mediana ";
                Total += 5700;
            }else if(buttonFamiliar.Checked == true)
            {
                tipoTamaño = "Familiar ";
                Total += 7600;
            }else if(buttonXL.Checked == true)
            {
                tipoTamaño = "XL ";
                Total += 12000;
            }
            
            if(buttonBebida.Checked == true)
            {
                tipoAgregado += "Bebida ";
                Total += 500;
            }else if(buttonPapas.Checked == true)
            {
                tipoAgregado += "Papas ";
                Total += 500;
            }else if(buttonPA.Checked == true)
            {
                tipoAgregado += "Palitos de ajo ";
                Total += 1000;
            }

            ListaPedidos.Items.Add(tipoPizza + tipoTamaño +"+ "+ tipoAgregado + "$"+Total);

            listaTotal.Add(Total);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //meter en un for para eliminar de uno en uno
            var count = listaTotal.Count();
            for (int i = 0; i < count; i++)
            {
                if (i == ListaPedidos.SelectedIndex)
                {
                    listaTotal.RemoveAt(i);
                    ListaPedidos.Items.RemoveAt(i);
                    Console.WriteLine(i);
                }
            }
            
        }

        private void buttonCalcular2_Click(object sender, EventArgs e)
        {
            //labelTotalPedido.Text = ListaPedidos.CheckedItems.ToString();
            int[] arrayTotal = listaTotal.ToArray();
            int totalCuentaP = arrayTotal.Sum();
            labelTotalPedido.Text = totalCuentaP.ToString();
        }

        private void Caja_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
