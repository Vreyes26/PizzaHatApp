using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        
        //AGREGAR PEDIDO
        private void button1_Click(object sender, EventArgs e)
        {
            int Total = 0;
            string tipoPizza = "";
            string tipoTamaño = "";
            string tipoAgregado = "";
            
            //SELECCION PIZZA
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

            //TAMAÑO PIZZA
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

            //AGREGADO
            if(buttonBebida.Checked == true)
            {
                tipoAgregado += "+ Bebida ";
                Total += 500;
            }else if(buttonPapas.Checked == true)
            {
                tipoAgregado += "+ Papas ";
                Total += 500;
            }else if(buttonPA.Checked == true)
            {
                tipoAgregado += "+ Palitos de ajo ";
                Total += 1000;
            }

            //AGREGAR PRODUCTOS
            ListaPedidos.Items.Add(tipoPizza + tipoTamaño + tipoAgregado + "$"+Total);

            //PRECIO TOTAL
            listaTotal.Add(Total);

            //FORMATO DEL PRECIO TOTAL
            /*int[] arrayTotal = listaTotal.ToArray();
            int totalCuentaP = arrayTotal.Sum();
            string conv = String.Format("{0:c0}", totalCuentaP);
            labelTotalPedido.Text = conv;*/
            actualizarPrecio();
        }

        //ACTUALIZAR PRECIO TOTAL
        private void actualizarPrecio()
        {
            int[] arrayTotal = listaTotal.ToArray();
            int totalCuentaP = arrayTotal.Sum();
            string conv = String.Format("{0:c0}", totalCuentaP);
            labelTotalPedido.Text = conv;
        }

        //ELIMINAR UN PEDIDO
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
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
            actualizarPrecio();
        }

        private void Caja_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //ELIMINAR TODOS LOS PEDIDOS
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Desea eliminar todos los pedidos?", "Precaucion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                ListaPedidos.Items.Clear();
                listaTotal.Clear();
            }
        }

        //GUARDAR ORDEN
        private void buttonSaveOrden_Click(object sender, EventArgs e)
        {
            int[] arrayTotal = listaTotal.ToArray();
            int totalCuentaP = arrayTotal.Sum();
            string totalOrden = String.Format("{0:c0}", totalCuentaP);

            string nameArchivo = "ordenSave.txt";
            saveFileDialog1.FileName = nameArchivo;
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ListaPedidos.Items.Add("Total: "+totalOrden);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    foreach (var item in ListaPedidos.Items)
                    { sw.WriteLine(item.ToString()); };
                MessageBox.Show("Orden guardada con exito!");
            }
            else
            {
                MessageBox.Show("Orden no guardada");
            }
            
            ListaPedidos.Items.Clear();
            listaTotal.Clear();
        }
    }
}
