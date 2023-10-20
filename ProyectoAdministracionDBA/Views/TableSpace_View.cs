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
            NameLabel.Dock = DockStyle.Fill;
            FileDirLabel.Dock = DockStyle.Fill;
            AutoExtendCheck.Dock = DockStyle.Fill;
            TamannoIncrementoTextBox.Dock = DockStyle.Fill;
            MaxSizeTextBox.Dock = DockStyle.Fill;
            BtnUpdate.Dock = DockStyle.Fill;
            SizeTextBox.Dock = DockStyle.Fill;




            NameLabel.Text = table.Name;
            FileDirLabel.Text = table.File_Dir;
            SizeTextBox.Text = table.Size;
            TamannoIncrementoTextBox.Text = table.TamannoIncremento;
            AutoExtendCheck.Checked = table.AutoExtend;
            MaxSizeTextBox.Text = table.MaxSize;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConection.ChangeTableSpaceSize(this.table);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            this.table.Size = SizeTextBox.Text;


        }
    }
}
