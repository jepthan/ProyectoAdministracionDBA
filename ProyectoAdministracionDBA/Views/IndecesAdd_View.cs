using ProyectoAdministracionDBA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAdministracionDBA.Views
{
    public partial class IndecesAdd_View : UserControl
    {
        public IndecesAdd_View()
        {
            InitializeComponent();
            indice = new Indice("", "", "");
            //this.Dock = DockStyle.Fill;
        }
        private Indice indice { get; set; }

        private string name { get; set; }

        private void NombreAddTB_TextChanged(object sender, EventArgs e)
        {
            indice.Nombre = NombreAddTB.Text;
        }

        private void TablaAddTB_TextChanged(object sender, EventArgs e)
        {
            indice.Tabla = TablaAddTB.Text;
        }

        private void ColumnaAddTB_TextChanged(object sender, EventArgs e)
        {
            indice.Columna = ColumnaAddTB.Text;
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            indice.addIndex();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.name = NombreRecTB.Text;
        }

        private void ReconstruirBtn_Click(object sender, EventArgs e)
        {
            indice.ReconstruirIndice(this.name);
        }
    }
}
