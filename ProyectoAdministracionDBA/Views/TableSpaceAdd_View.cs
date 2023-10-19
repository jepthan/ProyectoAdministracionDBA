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
    public partial class TableSpaceAdd_View : UserControl
    {
        public TableSpaceAdd_View()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.Red;
            
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //this.Width = Parent.Width;
            //this.Height = Parent.Height;
        }
    }
}
