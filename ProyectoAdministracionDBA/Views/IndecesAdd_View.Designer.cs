namespace ProyectoAdministracionDBA.Views
{
    partial class IndecesAdd_View
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
            label5 = new Label();
            label2 = new Label();
            NombreAddTB = new TextBox();
            label3 = new Label();
            TablaAddTB = new TextBox();
            label4 = new Label();
            ColumnaAddTB = new TextBox();
            AgregarBtn = new Button();
            label6 = new Label();
            label7 = new Label();
            NombreRecTB = new TextBox();
            ReconstruirBtn = new Button();
            label9 = new Label();
            label8 = new Label();
            DeleteNameTB = new TextBox();
            DeliteIndexBtn = new Button();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(NombreAddTB);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(TablaAddTB);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(ColumnaAddTB);
            flowLayoutPanel1.Controls.Add(AgregarBtn);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(NombreRecTB);
            flowLayoutPanel1.Controls.Add(ReconstruirBtn);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(DeleteNameTB);
            flowLayoutPanel1.Controls.Add(DeliteIndexBtn);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(371, 400);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 6);
            label5.Margin = new Padding(3, 6, 3, 6);
            label5.Name = "label5";
            label5.Size = new Size(171, 31);
            label5.TabIndex = 8;
            label5.Text = "Agregar Indece";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 43);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // NombreAddTB
            // 
            NombreAddTB.Location = new Point(3, 66);
            NombreAddTB.Name = "NombreAddTB";
            NombreAddTB.Size = new Size(171, 27);
            NombreAddTB.TabIndex = 2;
            NombreAddTB.TextChanged += NombreAddTB_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Tabla";
            // 
            // TablaAddTB
            // 
            TablaAddTB.Location = new Point(3, 119);
            TablaAddTB.Name = "TablaAddTB";
            TablaAddTB.Size = new Size(171, 27);
            TablaAddTB.TabIndex = 4;
            TablaAddTB.TextChanged += TablaAddTB_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 149);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 5;
            label4.Text = "Columna";
            // 
            // ColumnaAddTB
            // 
            ColumnaAddTB.Location = new Point(3, 172);
            ColumnaAddTB.Name = "ColumnaAddTB";
            ColumnaAddTB.Size = new Size(171, 27);
            ColumnaAddTB.TabIndex = 6;
            ColumnaAddTB.TextChanged += ColumnaAddTB_TextChanged;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(3, 205);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(171, 45);
            AgregarBtn.TabIndex = 7;
            AgregarBtn.Text = "Agregar Indice";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 259);
            label6.Margin = new Padding(3, 6, 3, 6);
            label6.Name = "label6";
            label6.Size = new Size(184, 31);
            label6.TabIndex = 9;
            label6.Text = "Recostruir Indice";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 296);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 10;
            label7.Text = "Nombre de Indice";
            // 
            // NombreRecTB
            // 
            NombreRecTB.Location = new Point(3, 319);
            NombreRecTB.Name = "NombreRecTB";
            NombreRecTB.Size = new Size(171, 27);
            NombreRecTB.TabIndex = 11;
            NombreRecTB.TextChanged += textBox4_TextChanged;
            // 
            // ReconstruirBtn
            // 
            ReconstruirBtn.Location = new Point(3, 352);
            ReconstruirBtn.Name = "ReconstruirBtn";
            ReconstruirBtn.Size = new Size(171, 45);
            ReconstruirBtn.TabIndex = 12;
            ReconstruirBtn.Text = "Reconstruir";
            ReconstruirBtn.UseVisualStyleBackColor = true;
            ReconstruirBtn.Click += ReconstruirBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(193, 0);
            label9.Name = "label9";
            label9.Size = new Size(171, 31);
            label9.TabIndex = 16;
            label9.Text = "Eliminar indece";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(193, 31);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 13;
            label8.Text = "Nombre ";
            // 
            // DeleteNameTB
            // 
            DeleteNameTB.Location = new Point(193, 54);
            DeleteNameTB.Name = "DeleteNameTB";
            DeleteNameTB.Size = new Size(171, 27);
            DeleteNameTB.TabIndex = 14;
            DeleteNameTB.TextChanged += DeleteNameTB_TextChanged;
            // 
            // DeliteIndexBtn
            // 
            DeliteIndexBtn.Location = new Point(193, 87);
            DeliteIndexBtn.Name = "DeliteIndexBtn";
            DeliteIndexBtn.Size = new Size(171, 40);
            DeliteIndexBtn.TabIndex = 15;
            DeliteIndexBtn.Text = "Eliminar indece";
            DeliteIndexBtn.UseVisualStyleBackColor = true;
            DeliteIndexBtn.Click += DeliteIndexBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 130);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // IndecesAdd_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "IndecesAdd_View";
            Size = new Size(371, 400);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox NombreAddTB;
        private Label label3;
        private TextBox TablaAddTB;
        private Label label4;
        private TextBox ColumnaAddTB;
        private Button AgregarBtn;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox NombreRecTB;
        private Button ReconstruirBtn;
        private Label label9;
        private Label label8;
        private TextBox DeleteNameTB;
        private Button DeliteIndexBtn;
    }
}
