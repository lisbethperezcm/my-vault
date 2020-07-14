using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCare_System.Interfaz
{
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Click_1(object sender, EventArgs e)
        {
            Form Agregar_citas = new Agregar_citas();
            Agregar_citas.Show();
        }
    }
}
