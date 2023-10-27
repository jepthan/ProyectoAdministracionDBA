using ProyectoAdministracionDBA.Models;
using ProyectoAdministracionDBA.Views;
using System.Diagnostics;

namespace ProyectoAdministracionDBA
{
    public partial class Form1 : Form
    {
        public static string user = "SYS";
        public static string pwd = "2711";
        public static int id = 0;

        public static string db = "localhost:1521/XEPDB1";
        public Form1()
        {
            InitializeComponent();
            List<TableSpace> results = TableSpace.GetTableSpaces();


            for (int i = 0; i < results.Count; i++)
            {

                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.Controls.Add(new TableSpace_View(results[i]));
                /*
                tableLayoutPanel1.Controls.Add(new Label { Text = results[i].Name, Margin = new Padding(5, 5, 5, 10), BackColor = Color.Red }, 0, i);
                tableLayoutPanel1.Controls.Add(new TextBox { Text = results[i].Size, Margin = new Padding(6, 6, 6, 6) }, 1, i);
                Button tempbtn = new Button { Text = "Actualisar", Margin = new Padding(6, 6, 6, 6), AutoSize = true };
                tempbtn.Click += btn_click;
                tableLayoutPanel1.Controls.Add(tempbtn, 2, i);
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));*/

            }
            tabControl1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tabControl1.Selected += TabControl1_Selected;
            
        }
        private void TabControl1_Selected(Object? sender, TabControlEventArgs e)
        {

            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "TabPage", e.TabPage);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "TabPageIndex", e.TabPageIndex);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Action", e.Action);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("this is debug information", "Action", e.Action);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Selected Event");
        }

    }
}