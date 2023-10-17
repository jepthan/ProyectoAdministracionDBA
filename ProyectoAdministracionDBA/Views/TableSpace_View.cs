using ProyectoAdministracionDBA.Models;

namespace ProyectoAdministracionDBA.Views
{
    public partial class TableSpace_View : UserControl
    {
        public TableSpace table;
        public TableSpace_View(TableSpace table)
        {
            this.table = table;
            InitializeComponent();

            label1.Text = table.Name;
            textBox1.Text = table.Size.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConection.ChangeTableSpaceSize(this.table);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            this.table.Size = textBox1.Text;


        }
    }
}
