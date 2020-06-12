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
        public Caja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Total = 0;
            double Cantidad;
            Array pedidos = new Array[0];

            if (buttonItaliana.Checked == true)
            {
                string tipoPizza = "Italiana";
                Total += 650;
            }
            else if (buttonEspañola.Checked == true)
            {
                string tipoPizza = "Española";
                Total += 1350;
            }else if(buttonHawaiiana.Checked == true)
            {
                string tipoPizza = "Hawaiiana";
                Total += 650;
            }

            if (buttonIndividual.Checked == true)
            {
                string tipoTamaño = "Individual";
                Total += 3250;
            }else if(buttonMediana.Checked == true)
            {
                string tipoTamaño = "Mediana";
                Total += 5700;
            }else if(buttonFamiliar.Checked == true)
            {
                string tipoTamaño = "Familiar";
                Total += 7600;
            }else if(buttonXL.Checked == true)
            {
                string tipoTamaño = "XL";
                Total += 12000;
            }

            label13.Text = Total.ToString();
        }

    }
}
