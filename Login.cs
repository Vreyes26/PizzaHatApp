using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaHatApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(User.Text == "admin" && Password.Text == "abc123")
            {
                this.Hide();
                Caja caja = new Caja();
                caja.Show();
            }
            else
            {
                string messaje = "Usuario o contraseña invalido";
                string tittle = "Error";
                MessageBox.Show(messaje, tittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
