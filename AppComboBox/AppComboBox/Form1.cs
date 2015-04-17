using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int cont;
            for (cont = 0; cont <= 255; cont++)
            {
                cmbRojo.Items.Add(cont.ToString());
                cmbVerde.Items.Add(cont.ToString());
                cmbAzul.Items.Add(cont.ToString());
            }
        }

        private void btnColorear_Click(object sender, EventArgs e)
        {
            int rojo, verde, azul;
            rojo = int.Parse(cmbRojo.Text);
            verde = int.Parse(cmbVerde.Text);
            azul= int.Parse(cmbAzul.Text);
            BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
