namespace ProyectoAdministracionDBA.Views
{
    partial class TableSpaceAdd_View
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            NombreLB = new Label();
            NombreTB = new TextBox();
            TamannoLB = new Label();
            TamannoTB = new TextBox();
            DirFIleLB = new Label();
            DirFileTB = new TextBox();
            AutoExCB = new CheckBox();
            TamIncreseLB = new Label();
            TamIncreseTB = new TextBox();
            TamMaxLB = new Label();
            TamMaxTB = new TextBox();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(NombreLB);
            flowLayoutPanel1.Controls.Add(NombreTB);
            flowLayoutPanel1.Controls.Add(TamannoLB);
            flowLayoutPanel1.Controls.Add(TamannoTB);
            flowLayoutPanel1.Controls.Add(DirFIleLB);
            flowLayoutPanel1.Controls.Add(DirFileTB);
            flowLayoutPanel1.Controls.Add(AutoExCB);
            flowLayoutPanel1.Controls.Add(TamIncreseLB);
            flowLayoutPanel1.Controls.Add(TamIncreseTB);
            flowLayoutPanel1.Controls.Add(TamMaxLB);
            flowLayoutPanel1.Controls.Add(TamMaxTB);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(878, 609);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // NombreLB
            // 
            NombreLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NombreLB.Location = new Point(3, 0);
            NombreLB.Name = "NombreLB";
            NombreLB.Size = new Size(291, 40);
            NombreLB.TabIndex = 0;
            NombreLB.Text = "Nombre";
            // 
            // NombreTB
            // 
            NombreTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NombreTB.Location = new Point(3, 43);
            NombreTB.Name = "NombreTB";
            NombreTB.Size = new Size(291, 43);
            NombreTB.TabIndex = 1;
            NombreTB.TextChanged += NombreTB_TextChanged;
            // 
            // TamannoLB
            // 
            TamannoLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TamannoLB.Location = new Point(3, 89);
            TamannoLB.Name = "TamannoLB";
            TamannoLB.Size = new Size(291, 38);
            TamannoLB.TabIndex = 3;
            TamannoLB.Text = "Tamaño";
            // 
            // TamannoTB
            // 
            TamannoTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TamannoTB.Location = new Point(3, 130);
            TamannoTB.Name = "TamannoTB";
            TamannoTB.Size = new Size(291, 43);
            TamannoTB.TabIndex = 4;
            TamannoTB.TextChanged += TamannoTB_TextChanged;
            // 
            // DirFIleLB
            // 
            DirFIleLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            DirFIleLB.Location = new Point(3, 176);
            DirFIleLB.Name = "DirFIleLB";
            DirFIleLB.Size = new Size(291, 47);
            DirFIleLB.TabIndex = 5;
            DirFIleLB.Text = "Direccion De Archivo";
            // 
            // DirFileTB
            // 
            DirFileTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            DirFileTB.Location = new Point(3, 226);
            DirFileTB.Name = "DirFileTB";
            DirFileTB.Size = new Size(291, 43);
            DirFileTB.TabIndex = 6;
            DirFileTB.TextChanged += DirFileTB_TextChanged;
            // 
            // AutoExCB
            // 
            AutoExCB.AutoSize = true;
            AutoExCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AutoExCB.Location = new Point(3, 275);
            AutoExCB.Name = "AutoExCB";
            AutoExCB.Size = new Size(176, 41);
            AutoExCB.TabIndex = 11;
            AutoExCB.Text = "AutoExtend";
            AutoExCB.UseVisualStyleBackColor = true;
            AutoExCB.CheckedChanged += AutoExCB_CheckedChanged;
            // 
            // TamIncreseLB
            // 
            TamIncreseLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TamIncreseLB.Location = new Point(3, 319);
            TamIncreseLB.Name = "TamIncreseLB";
            TamIncreseLB.Size = new Size(291, 44);
            TamIncreseLB.TabIndex = 7;
            TamIncreseLB.Text = "Tamaño de Incremento";
            // 
            // TamIncreseTB
            // 
            TamIncreseTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TamIncreseTB.Location = new Point(3, 366);
            TamIncreseTB.Name = "TamIncreseTB";
            TamIncreseTB.Size = new Size(291, 43);
            TamIncreseTB.TabIndex = 8;
            TamIncreseTB.TextChanged += TamIncreseTB_TextChanged;
            // 
            // TamMaxLB
            // 
            TamMaxLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TamMaxLB.Location = new Point(3, 412);
            TamMaxLB.Name = "TamMaxLB";
            TamMaxLB.Size = new Size(291, 38);
            TamMaxLB.TabIndex = 9;
            TamMaxLB.Text = "Tamaño Maximo";
            // 
            // TamMaxTB
            // 
            TamMaxTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TamMaxTB.Location = new Point(3, 453);
            TamMaxTB.Name = "TamMaxTB";
            TamMaxTB.Size = new Size(291, 43);
            TamMaxTB.TabIndex = 10;
            TamMaxTB.TextChanged += TamMaxTB_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 502);
            button1.Name = "button1";
            button1.Size = new Size(291, 51);
            button1.TabIndex = 12;
            button1.Text = "Agregar TableSpace";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TableSpaceAdd_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "TableSpaceAdd_View";
            Size = new Size(878, 609);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label NombreLB;
        private TextBox NombreTB;
        private Label TamannoLB;
        private TextBox TamannoTB;
        private Label DirFIleLB;
        private TextBox DirFileTB;
        private Label TamIncreseLB;
        private TextBox TamIncreseTB;
        private Label TamMaxLB;
        private TextBox TamMaxTB;
        private CheckBox AutoExCB;
        private Button button1;
    }
}
