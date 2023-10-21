using ProyectoAdministracionDBA.Models;

namespace ProyectoAdministracionDBA.Views
{
    public partial class TableSpaceAdd_View : UserControl
    {
        private TableSpace table;
        public TableSpaceAdd_View()
        {
            table = new TableSpace("", "", "");
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            /*
            label1.Dock = DockStyle.Fill;
            textBox1.Dock = DockStyle.Fill;
            label2.Dock = DockStyle.Fill;
            textBox3.Dock = DockStyle.Fill;
            label3.Dock = DockStyle.Fill;
            textBox2.Dock = DockStyle.Fill;
            label4.Dock = DockStyle.Fill;
            textBox4.Dock = DockStyle.Fill;
            label5.Dock = DockStyle.Fill;
            textBox5.Dock = DockStyle.Fill;
            */
            TamIncreseLB.Enabled = AutoExCB.Checked;
            TamIncreseTB.Enabled = AutoExCB.Checked;
            TamMaxLB.Enabled = AutoExCB.Checked;
            TamMaxTB.Enabled = AutoExCB.Checked;

            flowLayoutPanel1.BackColor = Color.White;


        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //this.Width = Parent.Width;
            //this.Height = Parent.Height;
            /*
            label1.Size = new Size(label1.Parent.Size.Width-5, 30);
            textBox1.Size = new Size(textBox1.Parent.Size.Width-5, 30);
            label2.Size = new Size(label2.Parent.Size.Width - 5, 30);
            textBox3.Size = new Size(textBox3.Parent.Size.Width - 5, 30);
            label3.Size = new Size(label3.Parent.Size.Width - 5, 30);
            textBox2.Size = new Size(textBox2.Parent.Size.Width - 5, 30);
            label4.Size = new Size(label4.Parent.Size.Width - 5, 30);
            textBox4.Size = new Size(textBox4.Parent.Size.Width - 5, 30);
            label5.Size = new Size(label5.Parent.Size.Width - 5, 30);
            textBox5.Size = new Size(textBox5.Parent.Size.Width - 5, 30);*/
        }

        private void NombreTB_TextChanged(object sender, EventArgs e)
        {
            table.Name = NombreTB.Text;
        }

        private void TamannoTB_TextChanged(object sender, EventArgs e)
        {
            table.Size = TamannoTB.Text;
        }

        private void DirFileTB_TextChanged(object sender, EventArgs e)
        {
            table.File_Dir = DirFileTB.Text;
        }

        private void TamIncreseTB_TextChanged(object sender, EventArgs e)
        {
            table.TamannoIncremento = TamIncreseTB.Text;
        }

        private void TamMaxTB_TextChanged(object sender, EventArgs e)
        {
            table.MaxSize = TamMaxTB.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.AddTableToDB();
        }

        private void AutoExCB_CheckedChanged(object sender, EventArgs e)
        {
            table.AutoExtend = AutoExCB.Checked;

            TamIncreseLB.Enabled = AutoExCB.Checked;
            TamIncreseTB.Enabled = AutoExCB.Checked;
            TamMaxLB.Enabled = AutoExCB.Checked;
            TamMaxTB.Enabled = AutoExCB.Checked;


        }
    }
}
